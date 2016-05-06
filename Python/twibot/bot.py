import tweepy
from secret import *
import time
import persistency
from datetime import datetime
import accounts

auth = tweepy.OAuthHandler(C_KEY, C_SECRET)
auth.set_access_token(A_TOKEN, A_TOKEN_SECRET)
api = tweepy.API(auth)#, wait_on_rate_limit=True''')

def getLastDaysTweets(username, days):
    end = False
    tweetsPage = 1
    while not end:
        try:
            time.sleep(0.3)
            items = api.user_timeline(username, page = tweetsPage)
            tweetsPage += 1
            for item in items:  
                if (datetime.now() - item.created_at).days <= 7:
                    yield item
                else: 
                    end = True
                    break
        except(TweepError):
            print("Cannot call twitter API!")

def selectBestTweet(tweets):
    result = None
    bestRating = 0
    for tweet in tweets:
        rating = (tweet.retweet_count + 0.8 * tweet.favorite_count)
        if rating > bestRating:
            bestRating = rating
            result = tweet
    return result
    
def isReplyProcessed(id):
    return persistency.isIdPersisted(id)

def refreshCachedBestTweet(acc):
    tweets = getLastDaysTweets(acc, 7)
    bestTweet = selectBestTweet(tweets)
    persistency.saveBestTweet(acc, bestTweet.created_at, bestTweet.id)
    return bestTweet 

def getBestTweet(acc):
    tweet = persistency.getBestTweet(acc)
    if not tweet or (datetime.now() - tweet.date).days > 1:
        return refreshCachedBestTweet(acc)
    else:
        return tweet 

def replyToTweetWithTopic(tweet, topicAccounts):
    for acc in topicAccounts:
        #weekTweets = list(getLastDaysTweets(acc, 7))
        #bestTweet = selectBestTweet(weekTweets)
        bestTweet = getBestTweet(acc) # 7 days are hardcoded
        try:
            link = '@{2} https://twitter.com/{0}/status/{1}'.format(
                bestTweet.user.screen_name, 
                bestTweet.id,
                tweet.user.screen_name)
            api.update_status(link, tweet.id)
        except(a):
            print('cannot send reply: {0}'.format(a))

def processReply(tweet):
    try:
        command = tweet.text
        if 'tech' in command:
            replyToTweetWithTopic(tweet, accounts.tech)
        elif 'culture' in command:
            replyToTweetWithTopic(tweet, accounts.culture)
        else: 
            print('command {0} is not supported yet'.format(command))
    except Exception as e:
        print("cannot process reply {0}, skipping: {1}".format(tweet.id, e))
    finally:
        persistency.persistId(tweet.id)
    
# main application loop
persistency.connect()
while True:
    time.sleep(40)
    tl = api.home_timeline()
    for tweet in [t for t in tl if t.in_reply_to_status_id and t.in_reply_to_user_id == 386968261]: 
        # we need replies to bot here
        if not isReplyProcessed(tweet.id):
            processReply(tweet)

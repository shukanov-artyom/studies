import tweepy
from secret import *
import time
import persistency

auth = tweepy.OAuthHandler(C_KEY, C_SECRET)
auth.set_access_token(A_TOKEN, A_TOKEN_SECRET)
api = tweepy.API(auth)

#i = 0
#while(True):
#    i += 1
#    time.sleep(5*60)
#    api.update_status('helloworld {0}'.format(i))

tl = api.home_timeline()
rts = api.retweets_of_me()

persistency.connect()
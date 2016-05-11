import psycopg2

_conn = None

def fmt(arg):
    return "'{0}'".format(arg)

def connect():
    global _conn
    connectionString = "dbname='twibot' user='twibot' host='46.101.249.248' password='twibot'"
    try:
        _conn = psycopg2.connect(connectionString)
    except (a):
        print(a)
        print("I am unable to connect to the database")
        
def isIdPersisted(id):
    global _conn  
    cur = _conn.cursor()
    cur.execute('SELECT Count(*) FROM "ProcessedReplies" WHERE ID={0}'.format(id))
    countStr = cur.fetchone()[0]
    count = int(countStr)
    cur.close()
    return count > 0
    
def persistId(id):
    global _conn
    cur = _conn.cursor()
    cur.execute('INSERT INTO "ProcessedReplies" (id) VALUES ({0})'.format(id))
    cur.close()
    _conn.commit()

def getBestTweet(acc):  
    global _conn
    cur = _conn.cursor()
    result = cur.execute('SELECT * FROM "BestTweets" WHERE "Acc"={0}'.format(fmt(acc)))
    cur.close()
    return result
    
def saveBestTweet(acc, date, id):  
    global _conn
    cur = _conn.cursor()
    query = '''select persistbesttweet({0}, {1}, {2})'''.format(fmt(acc), fmt(date), id)
    cur.execute(query)
    cur.close()
    _conn.commit()
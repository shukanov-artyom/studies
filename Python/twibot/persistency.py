import psycopg2

def connect():
    connectionString = "dbname='twibot' user='twibot' host='46.101.249.248' password='twibot'"
    try:
        conn = psycopg2.connect(connectionString)
    except (a):
        print(a)
        print("I am unable to connect to the database")
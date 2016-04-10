import random

counter = 0

def rnd(num, max):
    for i in range(0, num):
        yield random.randrange(0, max)

def getData(len):
    threshold = len*11
    return rnd(len, threshold)
    
def compex(data, k, l):
    global counter
    counter+=1
    if (data[k] > data[l]):
        (data[k], data[l]) = (data[l], data[k])
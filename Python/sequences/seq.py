import math

def isprime(num):
    sq = math.sqrt(num)
    hg = int(sq)
    for i in range(2, hg+1):
        if num % i == 0:
            return False
    return True

a = [i for i in range(1000) if isprime(i)]
print(a)
def F(n): # simplest algorythm possible
    if (n <= 1):
        return n
    return F(n-1) + F(n-2)

def Fmemoized(n, cache):
    if n <=1 :
        return n
    if cache[n]:
        return cache[n]
    else:
        result = Fmemoized(n-2, cache) + Fmemoized(n-1, cache)
        cache[n] = result
        return result

def F2(n): # memoized algorythm
    cache = [None]*(n+1)
    cache[0] = 0
    return Fmemoized(n, cache)
    
print(F2(4))
    

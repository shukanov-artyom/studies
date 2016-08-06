def NaiveGCD(a, b): 
    result = 0
    for i in range(1, a+b+1):
        if a % i == 0 and b % i == 0:
            result = i
    return result
    
def EuclidGCD(a, b):
    if b == 0: return a
    return EuclidGCD(b, a%b)
    
print(NaiveGCD(4, 8))
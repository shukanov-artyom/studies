import math 

arr = range(1, 25)
l = [a*math.pi for a in arr if a > 3]

il = (a*math.pi for a in arr if a > 3)

print(type(il))
print(il)
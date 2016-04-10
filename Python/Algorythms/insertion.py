import sorting

data = list(sorting.getData(100))

i = 0
while i < len(data):
    j=i
    while j > 0:
        sorting.compex(data, j-1, j)
        j-=1
    i+=1

print(data)
print("compex was called {0} times".format(sorting.counter))
    

   




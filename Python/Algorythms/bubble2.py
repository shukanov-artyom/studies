from sorting import compex

inputFile = open('data.txt', 'r', 1)
bytes = inputFile.read()
values = []
for w in bytes.split(','): 
    values.append(int(w))
print(values)
r = len(values)
print("r=" + str(r))

for i in range(0, r):
    print("i=" + str(i))
    for j in range(1, r-i):
        compex(values, j-1, j)
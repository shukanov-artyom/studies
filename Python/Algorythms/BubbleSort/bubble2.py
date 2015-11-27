# сорировка пузырьком с прямым движением, наибольшее значение накапливается справа

inputFile = open('data.txt', 'r', 1)
bytes = inputFile.read() # считали полное содержимое файла в строку
values = []
for w in bytes.split(','): 
    values.append(int(w))
print(values)
r = len(values)
print("r=" + str(r))

for i in range(0, r):
    print("i=" + str(i))
    for j in range(1, r-i):
        if (values[j] < values[j-1]):
            (values[j], values[j-1]) = (values[j-1], values[j])
    print(values)
print(values)
input()
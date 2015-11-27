# сортировка пузырьком с обратным движением - наименьшее значение накапливается слева

inputFile = open('data.txt', 'r', 1)
bytes = inputFile.read() # считали полное содержимое файла в строку
values = []
for w in bytes.split(','): 
    values.append(int(w))
print(values)

for i in range(len(values)) :
    for j in range(len(values)-1, i, -1) : 
        print("j=" + str(j))
        if values[j] < values[j-1] :
            temp=values[j-1]
            values[j-1]=values[j]
            values[j]=temp
    print(values)
print(values)
input()

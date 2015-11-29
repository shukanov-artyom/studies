def encloser():
    n = 2
    action = (lambda x: n ** x)            # возводит переменную замыкания в заданную степень
    return action

act = encloser()
#print('closure variable: ' + str(act.n))    #  выдаёт ошибку - просто так не достучаться до переменной замыкания
print(act(10))                              # выводит два в заданной степени (1024)
import sys

print('\n1:\n')

# пример использования глобальной переменной в функции
X = 'variable'
def F1():
    print(X)
F1()

print('\n2:\n')

def F2():
    X = 'Ni!'
    print(X)    # локальная переменная скрывает глобальную
F2()
print(X)        # снова видна глобальная переменная

print('\n3:\n')

def F3():
    global X
    print(X)
    X = "Ni!"  # здесь происходит изменение глобальной переменной модуля
    print(X)
F3()
print(X)
X = 'variable'  # возвращаем как было

print('\n4:\n')

def F4():
    X = 'Ni4!'
    def F5():
        print(X)  # находим первую переменную в вышележащих пространствах имён
    F5()
F4()

print('\n5:\n')

X = 'variable'
def F6():
    X = 'Ni!'

    def F7():
        nonlocal X # из объемлющей функции
        print(X)
    F7()

    def F8():
        global X  # из пространства имён модуля
        print(X)
    F8()
F6()

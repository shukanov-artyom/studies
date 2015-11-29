import sys
from enum import Enum

# задаём конечный автомат

# пустая цепочка
eps = 'ε'

# пустое множество
emptySet = 'ø'

# алфавит
sigma = {0, 1}

# множество состояний
class Q(Enum):
    q1 = 1,
    q2 = 2,
    q3 = 3

# множество допустимых состояний
F = {Q.q3}

# начальное состояние
q0 = Q.q1

# функция переходов (адаптированная)
# состояние_1: {состояние_2: символ, состояние_3: символ}
delta = {
    1: {2: 0, 1: 1},
    2: {3: 0, 1: 1},
    3: {3: 0, 2: 1}
}

# функция конвертации конечного автомата в регулярное выражение
def toRegex():
    return 0
    # нужна рекурсивная функция нахождения регулярного выражения для перехода между двумя произвольными состояниями
    # для этого надо сначала найти нулевой уровень - это будет дном рекурсивной ямы

# i - начальное состояние
# j - конечное состояние
# k - максимальный номер состояния, через которое может проходить путь
def toRegexInternal(i, j, k):
    if k == 0:
        return getZeroLevel(i, j)
    else:
        A = toRegexInternal(i, j, k-1)
        B = toRegexInternal(i, k, k-1)
        C = toRegexInternal(k, k, k-1)
        D = toRegexInternal(k, j, k-1)
        result = "{0}+({1})({2})*({3})".format(A, B, C, D)
        return result

def getZeroLevel(i, j):
    result = ''
    if i == j:
        result += eps # из состояния в само себя можно переходить по эпсилон в любом случае
    mapping = delta[i] # тут все переходы из состояния i
    # есть два возможных варианта:
    #   - переход из i в i по символу, отличному от эпсилон (петля)
    #   - переход в другое состояние по некоторому символу из алфавита (возможно, эпсилон)
    toJ = mapping.get(j)
    if toJ is not None:
        if not result:  # проверка IsnullOrEmpty
            result = str(toJ)
        else:
            result = str.format('{0}+{1}', result, toJ)
    if not result:
        result = emptySet
    return result

# print('R=' + str(getZeroLevel(3,3)))
print('R=' + str(toRegexInternal(1,3,2)))



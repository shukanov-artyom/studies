import sys


def bynames(key, value): # здесь мы передаём аргументы, поменяв местами, но явно задавая имена аргументов.
    return {key: value}


def defaulted(key=11, value='val'):  # определяем значения по умолчанию, чтоб вообще не передавать аргументов
    return {key: value}  #  в заголовке = это не присваивание, а инструкция-модификатор сопоставления


def desequencer(*keys):
    result = []
    for k in keys:
        result.append(k)
    return result


def desequencernamed(*keys, additional1, additional2):
    result = []
    for k in keys:
        result.append(k)
    result.append(additional1)
    result.append(additional2)
    return result


def dedictionary(**keyvalues) -> 'annotation':
    return [keyvalues['a11'], keyvalues['a12']]


def complicated(par1, par2=0, *seqargs, mand1='m1', mand2, **dictargs):
    ''' полный набор: позиционный параметр, затем именованный параметр со значением по умолчанию
    затем кортеж переменного числа параметровб затем строго именованные параметры, один из них с умолчанием,
    затем словарь именованных параметров произвольных '''
    print(str(par1) + '.' + str(par2))
    for sa in seqargs:
        print(sa)
    for da in dictargs.keys():
        print(str(da) + ':' + str(dictargs[da]))
    print(mand1, mand2)


# ----------------------------------------

a = bynames(value='val', key=11)  # аргументы поменяли местами, но за счёт того, что именовали ,всё в порядке и семантика не нарушена
print(a)

b = defaulted()  # вообще не передаём никаких аргументов, работают умолчания
print(b)

c = desequencer(1, 2, 3, 4, 5, 6, 7, 8, 9)  # передаём не последовательность, а аргументы через запятые, по сути кортеж
print(c)

d = desequencernamed(1, 2, 3, 4, additional1='pep8', additional2='pepe')  # после нотированного одной звездой аргумента все остальные в python 3 должны передаваться именованными
print(d)

e = dedictionary(a11='pep8', a12='pepe')  # здесь = это не присваивание, а инструкция-модификатор сопоставления
print(e)

complicated(2, 3, 4, 5, mand2='m2', d1=7, d2=8, d3=9)  # вызов с использованием позиционного параметра, значения по умолчанию, одной звезды и двух звёздcomplicated(2, 3, 4, 5, d1=7, d2=8, d3=9)  # вызов с использованием позиционного параметра, значения по умолчанию, одной звезды и двух звёзд
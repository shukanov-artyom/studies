import sys

def decoratorFunc(f):
    '''
    wraps a function and returns a wrapped function instance
    '''
    print('generating decoration wrapper')
    def wrapperFunc(*args):
        print('decorated call')
        f(*args)
    return wrapperFunc

@decoratorFunc()
def originalFunc(a):
    print(a)

originalFunc("argmy")
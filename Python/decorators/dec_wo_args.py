class decoratorWithoutArgs(object):
    
    def __init__(self, f):
    '''decorator initializer. 
    for decorators without arguments this code is called on decoration'''
        print("--decorating with decorator--")
        self.f = f
    
    def __call__(self, *args):
        print("--decorated call--")
        self.f(*args)

print("let's decorate function call")
@decoratorWithoutArgs
def targetFunction(a):
    print(a)

print("let's call target function")
targetFunction("final argument!")
import sys

class embracingDecorator(object):
    
    def __init__(self, embracerOne, embracerTwo):
        '''
        this decorator constructor is called BEFORE decoration
        Here we persist decorator arguments in decorator instance properties
        '''
        self.embracerOne = embracerOne
        self.embracerTwo = embracerTwo
    
    def __call__(self, f):
        '''
        this method is called also at decoration time
        it receives original function and must provide another function to substitute original 
        '''
        
        def substitute(*args):
            print(self.embracerOne, end='')
            # use f closure here
            f(*args)
            print(self.embracerTwo, end='')
            
        return substitute
    
# using this decorator to decorate function
@embracingDecorator('[', ']')
def funct(symbol):
    print(symbol, end='')
        
funct('word')
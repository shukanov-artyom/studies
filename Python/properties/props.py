class A:
    def __init__(self):
        self._x = 0
    
    # static property
    staticprop = 10
    
    # .NET-style properties
    def getX(self):
        return self._x
    def setX(self, value):
        self._x = value

class B(A) : pass

a = A()
a.X = 10
print(a.X)

print("Statiscprop A value: {0}".format(A.staticprop))
print("Statiscprop B value: {0}".format(B.staticprop))

B.staticprop += 1

print("Statiscprop A value after B increment: {0}".format(A.staticprop))
print("Statiscprop B value after B increment: {0}".format(B.staticprop)) # because B is separate class object 

method = a.getX
print("Method function name: {0}".format(method.__name__))
print("Method self object: {0}".format(method.__self__))

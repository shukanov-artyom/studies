
class MyEnumerable:
    def __init__(self):
        self._a = "a"
        self._b = "b"
        self._c = "c"
        self._ctr = 0
        
    def __iter__(self):
        return self
    
    def __next__(self):
        if (self._ctr == 3):
            self._ctr = 0
            raise StopIteration
        else:
            if self._ctr == 0:
                self._ctr += 1
                return self._a
            if self._ctr == 1:
                self._ctr += 1
                return self._b
            else:
                self._ctr += 1
                return self._c

# builtin enumeration
for p in MyEnumerable():
    print(p)
    
# custom enumeration
me = MyEnumerable()
iter = iter(me) # builtin method to preserve incapsulation and consistency
print(next(iter))
print(next(iter))
print(next(iter))
print(next(iter))
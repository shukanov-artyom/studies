from math import sin

class A:
    def __init__(self):
        self._ctr = 0
    
    def gnr(self):
        """Generator function returns iterable sequence"""
        while self._ctr < 1:
            self._ctr += 0.1
            yield sin(self._ctr)

a = A()
for sn in a.gnr():
    print(sn)
print(a.gnr.__doc__)
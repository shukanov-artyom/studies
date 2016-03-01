import sys


def external():
    x = 20

    def internal():
        print(x)

    x = x + 10 # this will influence our closure variable!
    return internal

int1 = external()
int1()

int2 = external()
int2()
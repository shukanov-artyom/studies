class B(BaseException): pass
class C(BaseException): pass
class D(BaseException): pass

for cls in [B, C, D]:
    try:
        raise cls()
    except D:
        print("D")
    except C:
        print("C")
    except B:
        print("B")
        
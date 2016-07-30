def outer():
    a = 1
    def inner():
        nonlocal a
        b = a
        del a # deleting a 
    inner()
    print(a) # attempt to use deleted reference

outer()
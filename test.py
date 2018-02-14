import datetime
def fib(n):
    if n<3:
        return 1
    return fib(n-1) + fib(n-2)


if __name__ == '__main__':
    a = datetime.datetime.now()
    s = fib(40)
    b = datetime.datetime.now()
    c = b - a
    print(c.seconds)
    print(s)
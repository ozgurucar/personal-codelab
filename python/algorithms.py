
import numpy as np

def hello():
    print('Hello World!2')

a = np.arange(1,50)

def calc_array(a,step,total):
    if step == len(a):
        return total
    else:
        total = total + a[step]
        return calc_array(a,step + 1,total)
    
print(calc_array(a,0,0))


def iterative_fibonacci(n):
    a = 1
    b = 1
    for _ in range(n):
        a, b = b, a+b
    print(b)
    
iterative_fibonacci(7)


def one_to_three(n):
    if n == 0:
        return 1
    if n == 1:
        return 3
    return one_to_three(n -1) * one_to_three(n -2)

print(one_to_three(4))
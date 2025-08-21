numbers = [8 , 3 , 5 ,7 , 9 , 11]
permutations = [[]]
for number in numbers:
    new_perms = []
    for p in permutations:
        for i in range(len(p) + 1):
            new_perms.append(p[:i] + [number] + p[i:])
    permutations = new_perms


sorted_list = None
for p in permutations:
    flag = True
    for i in range(len(p) - 1):
        if p[i] > p[i + 1]:
            flag = False
            break
    if flag == True:
        sorted_list = p
        break

print(sorted_list)





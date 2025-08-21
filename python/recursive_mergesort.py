A = [1, 3, 5, 2, 11, 77, 24, 77, 36]

def merge_sort(A):
    print(f"A: {A}")
    if len(A) <= 1:
        return A
    mid = len(A) // 2
    left = merge_sort(A[:mid])
    print(f"left : {left}")
    right = merge_sort(A[mid:])
    print(f"right: {right}")
    return merge(left,right)

def merge(left,right):
    i = 0 
    j= 0
    output = []
    while i < len(left) and j < len(right):
        if left[i] < right[j]:
            output.append(left[i])
            i+=1
        else:
            output.append(right[j])
            j+=1
    while i < len(left):
        output.append(left[i])
        i+= 1
    while j < len(right):
        output.append(right[j])
        j+=1
    print(f"output: {output}")
    return output


merge_sort(A)

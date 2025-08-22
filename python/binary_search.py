A = [1,3,5,1,2,3,1,3,5,2,35,235,12,12,1,41,2,12,123]

A.sort()

def binarySearch(A,n):
    if len(A) <= 1:
        return False
    mid_index = len(A) // 2
    mid = A[mid_index]
    if mid < n:
        return binarySearch(A[mid_index:],n)
    elif mid > n:
        return binarySearch(A[:mid_index],n)
    else:
        return True

print(binarySearch(A,1234125))
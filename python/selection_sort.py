nums = [8, 2, 4, 9, 3]

j = len(nums)

for i in range(len(nums)):
    max = float("-inf")
    max_index = -1 
    for k in range(j):
        if nums[k] > max:
            max = nums[k]
            max_index = k    
    j -= 1
    temp = nums[max_index]
    nums[max_index] = nums[j]
    nums[j] = temp

print(nums)
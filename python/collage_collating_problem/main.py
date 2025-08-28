from DoubleLinkedList import DoubleLinkedList 
from Node import Node

def main():
    nums = [[1,None],[3,None],[5,None],[7,None],[9,None],[11,None]]
    DL = DoubleLinkedList()
    for i in range(len(nums)):
        node:Node = DL.add(nums[i][0])
        nums[i][1] = node
    print(nums[1][1].value)

    for v in DL:
       print(v)
    
    print(nums)

if __name__ == "__main__":
    main()
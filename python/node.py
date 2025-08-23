class Node:
    next = None
    value = None

    def __init__(self,value):
        self.value = value
        self.next = None

    def setNext(self,node):
        self.next = node

    def getNext(self):
        return self.next
    
    def getValue(self):
        return self.value
    

node1 = Node(1)
node2 = Node(2)
node3 = Node(3)
node4 = Node(4)
node5 = Node(5)
node6 = Node(6)
node7 = Node(7)
node8 = Node(8)

node1.setNext(node2)
node2.setNext(node3)
node3.setNext(node4)
node4.setNext(node5)
node5.setNext(node6)
node6.setNext(node7)
node7.setNext(node8)


curr = node1

while curr is not None:
    print(curr.getValue())
    curr = curr.getNext()
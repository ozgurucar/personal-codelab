from Node import Node

class DoubleLinkedList:
    def __init__(self):
        self.head = None
        self.len = 0

    def add_node(self,node:Node):
        if self.head == None:
            self.head = node
        else:
            x = self.head
            while(x.next != None):
                x = x.next
            x.next = node
            node.prev = x
        self.len += 1

    def add(self,value):
        self.add_node(Node(value))           




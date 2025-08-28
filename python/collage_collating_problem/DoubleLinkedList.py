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

    def __iter__(self):
        curr = self.head
        while(curr.next is not None):
            yield curr.value 
            curr = curr.next

    def __str__(self):
        parts = []
        curr = self.head
        while curr is not None:
            parts.append(str(curr.value))
            curr = curr.next
        return " -> ".join(parts) + " -> None"



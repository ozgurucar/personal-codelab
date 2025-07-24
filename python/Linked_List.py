class Node:
    def __init__(self,value):
        self.value = value
        self.next = None

class LinkedList():
    def __init__(self):
        self.head = None

    def list_is_empty(self):
        return self.head is None

    def add_element(self,node):
        if(self.list_is_empty()):
            self.head = node
        else:
            current = self.head
            while current.next is not None:
                current = current.next
            current.next = node

    def print_list(self):
        current = self.head
        while(current is not None):
            print(current.value)
            current = current.next

    def remove_element(self,value):
        if self.list_is_empty():
            return

        if self.head.value == value:
            self.head = self.head.next
            return

        prev = self.head
        walk = self.head.next

        while walk is not None:
            if walk.value == value:
                prev.next = walk.next
                return
            prev = walk
            walk = walk.next

        print("Can't found the element")



if __name__ == '__main__':
    my_linked_list = LinkedList()
    my_linked_list.add_element(Node(5))
    my_linked_list.add_element(Node(10))
    my_linked_list.add_element(Node(20))
    my_linked_list.print_list()
    my_linked_list.remove_element(102)
    my_linked_list.print_list()

from binary_node import Node

class BST:
    def __init__(self):
        self.root = None

    def insert(self, value):
        if self.root is None:
            self.root = Node(value)
        else:
            curr = self.root
            while True:
                if value < curr.value:
                    if curr.left is None:
                        curr.left = Node(value)
                        break
                    curr = curr.left
                else:
                    if curr.right is None:
                        curr.right = Node(value)
                        break
                    curr = curr.right

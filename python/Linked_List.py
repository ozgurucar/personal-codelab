from node import Node  # import the class, not the module name

class LinkedList:
    def __init__(self):
        self.head = None
        self.length = 0

    def add_node(self, new_node: Node):
        if self.head is None:
            self.head = new_node
        else:
            curr = self.head
            # stop at the tail
            while curr.getNext() is not None:
                curr = curr.getNext()
            curr.setNext(new_node)
        self.length += 1

    # convenience
    def add(self, value):
        self.add_node(Node(value))

    def __len__(self):
        return self.length
    def __iter__(self):
        curr = self.head
        while curr is not None:
            yield curr.getValue()
            curr = curr.getNext()

    def __str__(self):
        parts = []
        curr = self.head
        while curr is not None:
            parts.append(str(curr.getValue()))
            curr = curr.getNext()
        return " -> ".join(parts) + " -> None"

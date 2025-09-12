class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

    def insert_left(self,value):
        try:
            if self.left is None:
                self.left = Node(value)
        except Exception as e:
            print(f"Error inserting {value} to the left: {e}")

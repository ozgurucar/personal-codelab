class Node:
    def __init__(self,value):
        self.value = value
        self.left:Node = None
        self.right:Node = None
        self.balance_factor = 0
        self.height = 0
        self.parent:Node = None

class AVLTree:
    def __init__(self):
        self.root:Node = None

    def _insert(self, value):
        if self.root is None:
            self.root = Node(value)
        else:
            node = self.root
            while True:
                if value < node.value:
                    if node.left is None:
                        node.left = Node(value)
                        node.left.parent = node
                        self._update_balance(node,-1)
                        break
                    node = node.left
                else:
                    if node.right is None:
                        node.right = Node(value)
                        node.right.parent = node
                        self._update_balance(node,+1)
                        break
                    node = node.right


    def rotate(self,node:Node):
            if node.balance_factor == 2:
                if node.parent is None:
                    node.right.left = node
                    node.parent = node.right
                    node.right = None

                else:
                    node.right.left = node
                    node.parent.right = node.right
                    node.parent = node.right
                    node.right = None
            
            elif node.balance_factor == -2:
                if node.parent is None:
                    node.left.right = node
                    node.parent = node.left
                    node.left = None
                
                else:
                    node.left.right = node
                    node.parent.left = node.left
                    node.parent = node.left
                    node.left = None    

    def _update_balance(self, node:Node,l_r):
        if node.parent is None:
            return
        
        if node.parent.height != node.height + 1:
            node.parent.height = node.height + 1

        node.parent.balance_factor += l_r

        if  -2 == node.parent.balance_factor or 2 == node.parent.balance_factor:
            self.rotate(node.parent)

        self._update_balance(node.parent, l_r)



            

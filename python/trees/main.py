# from bst import BST

# bst = BST()

# values = [7, 3, 9, 1, 5, 8, 10]

# for v in values:
#     bst.insert(v)

# curr = bst.root

# print("In-order Traversal:")
# def in_order(node):
#     if node:
#         in_order(node.left)
#         print(node.value, end=' ')
#         in_order(node.right)

# def pre_order(node):
#     if node:
#         print(node.value,end=' ')
#         pre_order(node.left)
#         pre_order(node.right)

# in_order(curr)
# print("\n")
# print("Pre-order Traversal:")
# pre_order(curr)


from avl import AVLTree, Node

AVLTree = AVLTree()

values = [1,3,5,13,23,66,85,23]

for v in values:
    AVLTree._insert(v)
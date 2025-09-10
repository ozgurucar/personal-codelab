from generate_structure import root, Folder, File  # Ensure Folder and File are imported

# Ensure root is initialized with subfolders if not already defined
if not hasattr(root, 'subfolders'):
    root.subfolders = []
from collections import deque

items = deque()
items.append((root, 0))  # (item, depth)

while items:
    current, depth = items.popleft()
    print("  " * depth + f"Folder: {current.name}")  # Print folder name with indentation
    for subitem in current.subfolders:
        if isinstance(subitem, Folder):  # Check if subitem is a Folder
            items.append((subitem, depth + 1))
        elif isinstance(subitem, File):  # Check if subitem is a File
            print("  " * (depth + 1) + f"File: {subitem.name}")  # Print file name with indentation
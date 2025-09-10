import random
import string

class File:
    def __init__(self, content, name):
        self.content = content
        self.name = name

class Folder:
    def __init__(self, name):
        self.name = name
        self.subfolders = []

    def add_subdir(self, subdir):
        self.subfolders.append(subdir)

def random_name(length=8):
    """Generate a random name with the given length."""
    return ''.join(random.choices(string.ascii_letters + string.digits, k=length))

def create_random_structure(base_folder, num_folders=5, num_files=10, depth=3):
    """Create a random folder and file structure using custom Folder and File classes."""
    if depth == 0:
        return

    for _ in range(num_folders):
        folder_name = random_name()
        subfolder = Folder(folder_name)
        base_folder.add_subdir(subfolder)

        # Recursively create subfolders and files
        create_random_structure(subfolder, num_folders, num_files, depth - 1)

    for _ in range(num_files):
        file_name = random_name() + ".txt"
        file = File("This is a random file.", file_name)
        base_folder.add_subdir(file)

# Define root outside the main block for importability
root = Folder("root")
create_random_structure(root, num_folders=3, num_files=5, depth=2)

if __name__ == "__main__":
    # The script can still be run directly
    pass

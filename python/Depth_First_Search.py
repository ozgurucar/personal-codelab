from collections import deque

def dfs(graph, node, visited=None):
    if visited is None:
        visited = set()
    print(node)
    visited.add(node)

    for neighbor in graph[node]:
        if neighbor not in visited:
            dfs(graph,neighbor,visited)



graph = {
    'A': ['B', 'C'],
    'B': ['D', 'E'],
    'C': ['F'],
    'D': [],
    'E': [],
    'F': []
}



if __name__ == '__main__':
    dfs(graph,'A')

if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
    scores = student_marks.get(query_name)
    total = 0
    for score in scores:
        total += score
    total = total / len(scores)
    print(f"{total:.2f}")
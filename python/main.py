from linked_list import LinkedList



def change_order(list:LinkedList):
    mid = len(list) // 2
    a = list.head
    for _ in range(mid - 1):
        a = a.next
    b = a.next
    x_p = a
    x = b
    for _ in range(mid):
        x_n = x.next
        x.next = x_p
        x_p = x
        x = x_n
    c = x_p
    a.next = c
    b.next = None        



def main():
    ll = LinkedList()
    for i in range(1, 9):
        ll.add(i)

    # prints each value (uses __iter__)
    for v in ll:
        print(v)

    print(ll)        # 1 -> 2 -> ... -> 8 -> None
    change_order(ll)
    print(ll)




if __name__ == "__main__":
    main()





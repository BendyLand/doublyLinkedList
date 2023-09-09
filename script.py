from doubly_linked_list import *

lst = DoublyLinkedList()
lst.add_to_head("Ben")
lst.add_to_head("Olivia")
lst.add_to_tail("Olivia")
print(lst.stringify_list())

lst.remove_head()
print(lst.stringify_list())
lst.remove_tail()
print(lst.stringify_list())

lst.remove_by_value("Ben")
print(lst.stringify_list() + "0")


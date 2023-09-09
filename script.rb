require './doubly_linked_list.rb'

lst = DoublyLinkedList.new
lst.add_to_head("Ben")
lst.add_to_head("Olivia")
lst.add_to_tail("Olivia")
puts lst.stringify_list

lst.remove_head
puts lst.stringify_list
lst.remove_tail
puts lst.stringify_list

lst.remove_by_value("Ben")
puts lst.stringify_list + "0"

require './node.rb'

class DoublyLinkedList
    def initalize()
        @head_node = nil
        @tail_node = nil
    end

    def add_to_head(new_value)
        new_head = Node.new(new_value)
        current_head = @head_node

        if !current_head.nil?
            current_head.prev_node = new_head
            new_head.next_node = current_head
        end

        @head_node = new_head

        if @tail_node.nil?
            @tail_node = new_head
        end
    end

    def add_to_tail(new_value)
        new_tail = Node.new(new_value)
        current_tail = @tail_node

        if !current_tail.nil?
            current_tail.next_node = new_tail
            new_tail.prev_node = current_tail
        end

        @tail_node = new_tail

        if @head_node.nil?
            @head_node = new_tail
        end
    end

    def remove_head()
        removed_head = @head_node

        if removed_head.nil?
            return nil
        end

        @head_node = removed_head.next_node

        if !@head_node.nil?
            @head_node.prev_node = nil
        end

        if removed_head == @tail_node
            self.remove_tail()
        end

        return removed_head.value 
    end

    def remove_tail()
        removed_tail = @tail_node

        if removed_tail.nil?
            return nil
        end

        @tail_node = removed_tail.prev_node

        if !@tail_node.nil?
            @tail_node.next_node = nil
        end

        if removed_tail == @head_node
            self.remove_head()
        end

        return removed_tail.value
    end

    def remove_by_value(value_to_remove)
        node_to_remove = nil
        current_node = @head_node

        while !current_node.nil?
            if current_node.value == value_to_remove
                node_to_remove = current_node
                break
            end
            current_node = current_node.next_node
        end

        if node_to_remove.nil?
            return nil
        end

        if node_to_remove == @head_node
            self.remove_head()
        elsif node_to_remove == @tail_node
            self.remove_tail()
        else
            next_node = node_to_remove.next_node
            prev_node = node_to_remove.prev_node
            next_node.prev_node = prev_node
            prev_node.next_node = next_node
        end

        return node_to_remove
    end

    def stringify_list()
        string = ""
        current_node = @head_node
        while current_node
            if not current_node.value.nil?
                string += current_node.value.to_s + "; "
            end
            current_node = current_node.next_node
        end
        return string
    end
end

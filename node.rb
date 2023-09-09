class Node
    attr_reader :value
    attr_accessor :next_node, :prev_node    
    def initialize(value, next_node = nil, prev_node = nil)
        @value = value
        @next_node = next_node
        @prev_node = prev_node
    end
end
using System;
using System.Collections.Generic;

    class Node<T>
    {
        public T Value
        { get; private set; }
        public Node<T> NextNode
        { get; set; }
        public Node<T> PrevNode
        { get; set; }

        public Node(T value, Node<T> nextNode = null, Node<T> prevNode = null)
        {
            Value = value;
            NextNode = nextNode;
            PrevNode = prevNode;
        }
    }
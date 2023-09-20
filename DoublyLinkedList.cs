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


class DoublyLinkedList<T>
{
    public Node<T> HeadNode
    { get; private set; }
    public Node<T> TailNode
    { get; private set; }

    public DoublyLinkedList()
    {
        HeadNode = null;
        TailNode = null;
    }

    public void AddToHead(T newValue)
    {
        Node<T> newHead = new Node<T>(newValue);
        Node<T> currentHead = HeadNode;
        if (currentHead is not null)
        {
            currentHead.PrevNode = newHead;
            newHead.NextNode = currentHead;
        }

        HeadNode = newHead;

        if (TailNode is null)
        {
            TailNode = newHead;
        }
    }

    public void AddToTail(T newValue)
    {
        Node<T> newTail = new Node<T>(newValue);
        Node<T> currentTail = TailNode;
        if (currentTail is not null)
        {
            currentTail.NextNode = newTail;
            newTail.PrevNode = currentTail;
        }

        TailNode = newTail;

        if (HeadNode is null)
        {
            HeadNode = newTail;
        }
    }

    public T RemoveHead()
    {
        Node<T> removedHead = HeadNode;
        if (removedHead is null)
        {
            return default;
        }

        HeadNode = removedHead.NextNode;

        if (HeadNode is not null)
        {
            HeadNode.PrevNode = null;
        }

        if (removedHead == TailNode)
        {
            RemoveTail();
        }

        return removedHead.Value;
    }

    public T RemoveTail()
    {
        Node<T> removedTail = TailNode;
        if (removedTail is null)
        {
            return default;
        }

        TailNode = removedTail.PrevNode;

        if (TailNode is not null)
        {
            TailNode.NextNode = null;
        }

        if (removedTail == HeadNode)
        {
            RemoveHead();
        }

        return removedTail.Value;
    }

    public Node<T> RemoveByValue(T valueToRemove)
    {
        Node<T> nodeToRemove = null;
        Node<T> currentNode = HeadNode;
        while (currentNode is not null)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Value, valueToRemove))
            {
                nodeToRemove = currentNode;
                break;
            }
            currentNode = currentNode.NextNode;
        }

        if (nodeToRemove == null)
        {
            return default;
        }

        if (EqualityComparer<Node<T>>.Default.Equals(nodeToRemove, HeadNode))
        {
            RemoveHead();
        }
        else if (nodeToRemove == TailNode)
        {
            RemoveTail();
        }
        else
        {
            Node<T> next = nodeToRemove.NextNode;
            Node<T> prev = nodeToRemove.PrevNode;
            next.PrevNode = prev;
            prev.NextNode = next;
        }

        return nodeToRemove;
    }

        public string Stringify()
        {
            string s = "";
            Node<T> current = HeadNode;
            while (current != null)
            {
                if (current.Value != null)
                {
                    s += Convert.ToString(current.Value ) + "; ";
                }
                current = current.NextNode;
            }
            return s;
        }
}
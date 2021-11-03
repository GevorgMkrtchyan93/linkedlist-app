﻿using System;

namespace LinkedListApp
{
    public class SingleLinkedList<T>
    {
        public Node<T> head;
        public void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node._next = head;
            head = new_node;
        }
        public void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode._next = new_node;
        }

        private Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp._next != null)
            {
                temp = temp._next;
            }
            return temp;
        }
        public void InsertAfter(Node<T> prev_node, T new_data)
        {
            if (prev_node == null)
            {
                throw new ArgumentNullException("The given previous node Cannot be null");
            }
            Node<T> new_node = new Node<T>(new_data);
            new_node._next = prev_node._next;
            prev_node._next = new_node;
        }
        public void DeleteNodebyKey(T key)
        {
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp != null && Equals(temp._data, key))
            {
                head = temp._next;
                return;
            }
            while (temp != null && !Equals(temp._data, key))
            {
                prev = temp;
                temp = temp._next;
            }
            if (temp == null)
            {
                return;
            }
            prev._next = temp._next;
        }
        public void Revers()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> temp = null;
            while (current != null)
            {
                temp = current._next;
                current._next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }
    }
}

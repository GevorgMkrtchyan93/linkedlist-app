using System;

namespace LinkedListApp
{
    public class DoubleLinkedList<T>
    {
        public DNode<T> head;
        public void InsertFront(T data)
        {
            DNode<T> newDNode = new DNode<T>(data);
            newDNode._next = head;
            newDNode._prev = null;
            if (head != null)
            {
                head._prev = newDNode;
            }
            head = newDNode;
        }
        public void InsertLast(T new_data)
        {
            DNode<T> newDNode = new DNode<T>(new_data);
            if (head == null)
            {
                newDNode._prev = null;
                head = newDNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode._next = newDNode;
            newDNode._prev = lastNode;
        }

        private DNode<T> GetLastNode()
        {
            DNode<T> temp = head;
            while (temp._next != null)
            {
                temp = temp._next;
            }
            return temp;
        }
        public void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                throw new ArgumentNullException("The given previous node Cannot be null");
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode._next = prev_node._next;
            prev_node._next = newNode;
            newNode._prev = prev_node;
            if (newNode._next != null)
            {
                newNode._next._prev = newNode;
            }
        }
        public void DeleteNodebyKey(T key)
        {
            DNode<T> temp = head;
            if (temp != null && Equals(temp._data, key))
            {
                head = temp._next;
                head._prev = null;
                return;
            }
            while (temp != null && !Equals(temp._data, key))
            {
                temp = temp._next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp._next != null)
            {
                temp._next._prev = temp._next;
            }
        }
        public void Revers()
        {
            DNode<T> prev = null;
            DNode<T> temp = null;
            DNode<T> current = head;
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

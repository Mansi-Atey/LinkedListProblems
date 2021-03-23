using System;
using System.Collections.Generic;
using System.Text;

namespace SortedLinkedList
{
   public class SortedLinkedList
    {
        public Node head;
        public SortedLinkedList()
        {
            this.head = null;
        }
        public void Add(int item)
        {
            Node node = new Node(item);
            Node current = head, previous = null;
            while (current != null && current.data < node.data)
            {
                previous = current;
                current = current.next;
            }
            if (previous == null)
                head = node;
            else
            {
                previous.next = node;
            }
            node.next = current;
        }
        public Node Pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return null;
            }
            else
            {
                Node popped = head;
                head = head.next;
                return popped;
            }
        }
        public Node RemoveLastNode()

        {
            if (head == null)
            {
                Console.WriteLine("Empty LinkedList");
                return null;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Node removedNode = temp.next;
                temp.next = null;
                return removedNode;
            }
        }
        public void Delete(int item)
        {
            Node temp = head, previous = null;
            if (temp != null && temp.data == item)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != item)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }
        public bool Search(int item)
        {
            if (head == null)
                return false;
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == item)
                        return true;
                    temp = temp.next;
                }
                return false;
            }
        }
        public int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
        public void Display()
        {
            if (head == null)
                System.Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Adding
{
    class LinkedList
    {
        internal Node head;
        public LinkedList()
        {
            this.head = null;
        }
        internal void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        internal void Display()
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

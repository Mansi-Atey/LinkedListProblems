using System;

namespace LinkedListUC
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(56);
            head.next = new Node(30);
            head.next.next = new Node(70);
        }
    }
}

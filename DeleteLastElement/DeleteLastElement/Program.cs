using System;

namespace DeleteLastElement
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Append(100);
            list.Insert(4, 12);
            list.Display();
            Node p = list.Pop();
            System.Console.WriteLine(p.data);
            list.Display();
        }
    }
}

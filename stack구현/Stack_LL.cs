using System;

namespace OOP_HW1
{
    public class Node
    {
        public string data;
        public Node next;
        public Node(string data)
        {
            this.data = data;
            next = null;
        }
    }
    public class Stack_LL
    {
        public Node head;
        public void push(string data)
        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
        }

        public void pop()
        {
            head = head.next;
        }

        public void print()
        {
            Console.WriteLine("===stack(LinkedList) 출력===");
            for (Node temp = head; temp != null; temp = temp.next)
            {
                Console.Write(temp.data + " ");
            }
            Console.WriteLine();
        }
    }
}
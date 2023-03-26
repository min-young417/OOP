using System;

namespace OOP_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack_arr stack1 = new Stack_arr();

            stack1.push("banana");
            stack1.push("apple");
            stack1.push("kiwi");
            stack1.push("orange");

            stack1.pop();
            stack1.pop();

            stack1.print();

            Console.WriteLine();

            Stack_LL stack2 = new Stack_LL();

            stack2.push("banana");
            stack2.push("apple");
            stack2.push("kiwi");
            stack2.push("orange");

            stack2.pop();
            stack2.pop();

            stack2.print();
        }
    }
}

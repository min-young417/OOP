using System;

namespace OOP_HW1
{
    public class Stack_arr
    {
        string[] arr;
        int top;
        public Stack_arr()
        {
            arr = new string[100];
            top = 0;
        }

        public void push(string data)
        {
            arr[top++] = data;
        } 

        public void pop()
        {
            top--;
            arr[top] = null;
        }

        public void print()
        {
            Console.WriteLine("===stack(array) 출력===");
            for(int i=top-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
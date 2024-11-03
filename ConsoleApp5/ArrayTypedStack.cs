using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ArrayTypedStack
    {
        int MAX;
        int top;
        object[] stack;

        public bool IsEmpty()
        {
            return (top < 0);
        }
        public ArrayTypedStack(int MAX)
        {
            stack = new object[MAX];
            this.MAX = MAX;
            top = -1;
        }
        public void Push(object data)
        {
            if (top < this.MAX)
            {
                stack[++top] = data;
            }
        }
        public object Pop()
        {
            object value = new object();

            if (top >= 0)
            {
                value = stack[top--];

            }
            return value;
        }
        public object Peek()
        {
            object value = new object();

            if (top >= 0)
                value = stack[top];

            return value;
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i].ToString());
                }
            }
        }
    }
}

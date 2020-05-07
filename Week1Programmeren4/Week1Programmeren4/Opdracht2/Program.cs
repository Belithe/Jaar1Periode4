using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        void Start()
        {
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
        }
        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(100);
                stack.Push(value);
                Console.WriteLine($"pushed {value}, new count: { stack.Count} ");
            }
        }
        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }

        void CheckValues(IStack stack)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stack.Contains(90 + i).ToString());

            }
        }

    }
}


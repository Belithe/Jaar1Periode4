using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    class ArrayStack : IStack
    {
        int[] stack;
        int latest;
        public ArrayStack(int capacity)
        {
            stack = new int[capacity];
            latest = 0;
        }
        public void Push(int value)
        {
            if(stack.Length == 0)
            {
                throw new Exception("Stack empty.");
            }
            stack[latest] = value;
            latest++;
        }

        public int Pop()
        {
                int toPop = stack[latest - 1];
                latest--;
                return toPop;
            
            
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < stack.Length; i++)
            {
                if(stack[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int Count { get { return latest; } }
        public bool IsEmpty { get { return (latest == 0); } }
    }

}

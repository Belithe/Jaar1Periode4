using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Pencil : IPencil
    {
        private int maxToWrite = 20;
        private int nrOfCharsWritten;
        public bool CanWrite { get { return (nrOfCharsWritten != maxToWrite); } }

        public void Write(string message) {
            
            
            foreach (char letter in message)
            {
                if(nrOfCharsWritten == maxToWrite)
                {
                    Console.Write("#");
                } 
                else
                {
                    Console.Write(letter);
                    nrOfCharsWritten++;
                }
            }
            Console.WriteLine();
            
        }

        public void AfterSharpening() {
            nrOfCharsWritten = 0;
        }
    }
}

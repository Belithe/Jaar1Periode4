using System;

namespace Opdracht3
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
            PencilSharpener sharper = new PencilSharpener();
            Pencil pencil = new Pencil();

            bool running = true;
            while (running)
            {

                Console.Write("Please input: ");
                string input = Console.ReadLine();
                if (input == "sharpen")
                {
                    Console.WriteLine("sharpening...");
                    sharper.Sharpen(pencil);
                }
                else if (input == "stop")
                {
                    Console.WriteLine("ending...");
                    running = false;
                }
                else
                {
                    pencil.Write(input);
                }
            }
        }
    }
}

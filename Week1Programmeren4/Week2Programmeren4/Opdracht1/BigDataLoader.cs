using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    abstract class BigDataLoader
    {
        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();

        public void Run()
        {
            Console.WriteLine("{ETL-process started}");
            Extract();
            Transform();
            Load();
            Console.WriteLine("{ETL-process ended}");
            Console.WriteLine();
        }

    }
}

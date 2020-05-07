using System;
using System.Collections.Generic;

namespace Opdracht1
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
            List<BigDataLoader> myList = new List<BigDataLoader>();
            BatchProcessor processor = new BatchProcessor(myList);

            processor.AddDataToList(new CallDataLoader(), myList);
            processor.AddDataToList(new TwitterDataLoader(), myList);
            processor.AddDataToList(new SensorDataLoader(), myList);

            processor.WriteListOfData(myList);
        }
    }
}

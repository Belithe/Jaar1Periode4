using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class BatchProcessor
    {
        List<BigDataLoader> listToProcess = new List<BigDataLoader>();
        public BatchProcessor(List<BigDataLoader> listOfData)
        {
            listToProcess = listOfData;
        }
        public List<BigDataLoader> AddDataToList(BigDataLoader dataToAdd, List<BigDataLoader> listToUse)
        {
            listToUse.Add(dataToAdd);
            return listToUse;
        }

        public void WriteListOfData(List<BigDataLoader> dataList)
        {
            foreach (BigDataLoader item in dataList)
            {
                Console.WriteLine("{ETL-process started}");
                item.Extract();
                item.Transform();
                item.Load();
                Console.WriteLine("{ETL-process ended}");
                Console.WriteLine();
            }
        }

    }
}

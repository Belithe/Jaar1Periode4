using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Programmeren4
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }
        public Magazine(string title, float price, int numberofitems, DayOfWeek releaseday) : base (title, price, numberofitems)
        {
            ReleaseDay = releaseday;
        }
    }
}

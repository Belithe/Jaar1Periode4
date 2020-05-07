using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Programmeren4
{
    class CD : BookStoreItem
    {
        public string Artist { get; set; }
        public CD(string title, float price, int numberofitems, string artist) : base(title, price, numberofitems)
        {
            Artist = artist;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Programmeren4
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem(string title, float price, int NoOfItems)
        {
            Title = title;
            Price = price;
            NumberOfItems = NoOfItems;
        }

    }
}

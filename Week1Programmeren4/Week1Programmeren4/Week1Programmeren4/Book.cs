using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Programmeren4
{
    class Book : BookStoreItem
    {
        public string Author { get; set; }
        public Book(string title, float price, int NoOfItems, string author) : base(title, price, NoOfItems)
        {
            Author = author;
        }
    }
}

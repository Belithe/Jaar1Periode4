using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Programmeren4
{
    class BookStore
    {
        public List<BookStoreItem> bookStoreItems = new List<BookStoreItem>();

        public void Add(BookStoreItem itemToAdd)
        {
            bookStoreItems.Add(itemToAdd);
        }

        public void PrintAllItems()
        {
            for (int i = 0; i < bookStoreItems.Count; i++)
            {
                if(bookStoreItems[i].GetType().Name == "Book")
                {
                    Book itemToPrint = bookStoreItems[i] as Book;
                        Console.WriteLine(String.Format("{0}: {1}. For {2}. {3}x", itemToPrint.Author, itemToPrint.Title, itemToPrint.Price, itemToPrint.NumberOfItems));
                }
                if (bookStoreItems[i].GetType().Name == "CD")
                {
                    CD itemToPrint = bookStoreItems[i] as CD;
                    Console.WriteLine(String.Format("{0}: {1}. For {2}. {3}x", itemToPrint.Artist, itemToPrint.Title, itemToPrint.Price, itemToPrint.NumberOfItems));
                }
                if (bookStoreItems[i].GetType().Name == "Magazine")
                {
                    Magazine itemToPrint = bookStoreItems[i] as Magazine;
                    Console.WriteLine(String.Format("{0}: {1}. For {2}. {3}x", itemToPrint.ReleaseDay.ToString(), itemToPrint.Title, itemToPrint.Price, itemToPrint.NumberOfItems));
                }
            }





        }
    }
}

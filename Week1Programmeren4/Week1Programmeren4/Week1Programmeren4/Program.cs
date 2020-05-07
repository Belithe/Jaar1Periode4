using System;

namespace Week1Programmeren4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Start();
        }

        void Start()
        {
            BookStore store = new BookStore();

            store.bookStoreItems.Add(new Book("yeet", (float)3.50, 5, "goober"));
            store.bookStoreItems.Add(new Magazine("Daily Douchebags", (float)2.30, 1, DayOfWeek.Monday));
            store.bookStoreItems.Add(new CD("eating apples", 5, 3, "Jean Paul Loquat"));
            store.PrintAllItems();
        }
    }
}

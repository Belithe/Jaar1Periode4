using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak een MP3 player aan
            IObservable player = new MP3Player();
            // maak de displays aan
            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);
            // zet player op een nieuw nummer
            // (aangezien er geen hardware is, doen we dat hier...)
            player.NextSong();
            player.NextSong();
            player.NextSong();
            Console.ReadKey();
        }
    }
}

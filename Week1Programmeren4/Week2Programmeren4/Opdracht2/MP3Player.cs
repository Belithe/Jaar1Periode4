using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class MP3Player : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        List<Song> songs = new List<Song>();

        public MP3Player()
        {
            songs.Add(new Song("'Hello'", "02:55", "Me"));
            songs.Add(new Song("'Oops'", "04:29", "Mikey Mike and the Funky Bunch"));
        }

        public void AddObserver(IObserver observerToAdd)
        {
            observers.Add(observerToAdd);
        }
        public void RemoveObserver(IObserver observerToRemove)
        {
            observers.Remove(observerToRemove);
        }
        public Song CurrentSong { get; private set; }
        public void NextSong() {
            Random rnd = new Random();
            Song songToPlay = songs[rnd.Next(0, songs.Count)];
            foreach (IObserver observer in observers)
            {
                observer.Update(songToPlay);
            }
        
        }

    }
}

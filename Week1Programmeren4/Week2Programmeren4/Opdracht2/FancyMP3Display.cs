using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class FancyMP3Display : IObserver
    {
        public FancyMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine(String.Format("Fancy: {0} - {1} ({2})", song.name, song.artist, song.duration));
        }
    }
}

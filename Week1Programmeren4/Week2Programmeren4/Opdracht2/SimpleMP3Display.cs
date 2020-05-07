using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class SimpleMP3Display : IObserver
    {
        public SimpleMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine(String.Format("Simple: {0} - {1}", song.artist, song.name));
        }
    }
}

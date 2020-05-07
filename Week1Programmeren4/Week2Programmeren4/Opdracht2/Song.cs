using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    public class Song
    {
        public Song(string name, string duration, string artist)
        {
            this.name = name;
            this.duration = duration;
            this.artist = artist;
        }
        public string name;
        public string duration;
        public string artist;
    }
}

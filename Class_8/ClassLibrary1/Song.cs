using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre;

        public Song(string title,int length,Genre gen)
        {
            Title = title;
            Length = length;
            Genre = gen;
        }
    }
}

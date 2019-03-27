using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Movie
    {
        public Movie(string title,Genre gen, int rating,int price )
        {
            Title = title;
            Rating = rating;
            Genre = gen;
            TicketPrice = price;
        }

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get { return Rating;}
            set
            {
                if(Rating < 5 && Rating > 0)
                {
                    Rating = value;
                }
                else
                {
                    throw new Exception("Rating must be from one to five!");
                }
            }
        }
        public int TicketPrice { get; set; }
    }
}

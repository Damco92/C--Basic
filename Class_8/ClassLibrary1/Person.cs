using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public string ID { get; set; } = "0";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoreteMusicType;
        List<Song> favoriteSongs = new List<Song>();

        public Person(string first,string last,int age,Genre gen)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            FavoreteMusicType = gen;
        }


    }
}

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
        public List<Song> favoriteSongs = new List<Song>();

        public Person(string first,string last,int age,Genre gen)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            FavoreteMusicType = gen;
        }
        
        public void showFavoriteSongsTitles()
        {
            int counter = 0;
            foreach (var item in favoriteSongs)
            {
                if(!item.Title.Equals("") || !item.Title.Equals(null))
                { 
                counter = 1;
                Console.WriteLine(item.Title);
                } 
            }
            if (counter == 0) throw new Exception($"The person {FirstName} {LastName} hates music!");
        }
    }
}

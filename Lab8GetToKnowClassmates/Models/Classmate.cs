using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8GetToKnowClassmates.Models
{
    public class Classmate
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string FavoriteFood { get; set; }
        public List<Classmate> Classmates = new List<Classmate> {
            new Classmate("Mozart", "Salzburg", "Spaghetti"),
            new Classmate("Beethoven", "Bonn", "Hot Dogs"),
            new Classmate("Chopin", "Halle", "Cheese"),
        };

        public Classmate() { }

        public Classmate(string name, string hometown, string favoriteFood)
        {
            Name = name;
            Hometown = hometown;
            FavoriteFood = favoriteFood;
        }
    }
}

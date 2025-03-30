using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace famousPeople
{
    internal class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }

        
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
        };
            var after1900 = from s in stemPeople
                         where s.BirthYear > 1900
                select s;
            foreach(famousPeople person in after1900)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("-----------------------------------");
            var nameLs = from s in stemPeople
                         where s.Name.Contains("ll")
                select s;
            foreach (famousPeople person in nameLs)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("-----------------------------------");
            var num1950 = stemPeople.Count(s => s.BirthYear > 1950);
            Console.WriteLine($"{num1950}");
            var yrs19202000 = from s in stemPeople
                        where s.BirthYear > 1920 && s.BirthYear < 2000
                select s.Name;
            int yrsCount = yrs19202000.Count();
            foreach(string person in yrs19202000)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine($"There are {yrsCount} people in the query who were born between 1920 and 2000, exclusive.");
            Console.WriteLine("-----------------------------------");
            var sortYear = from s in stemPeople
                           orderby s.BirthYear
                select s;
            foreach(famousPeople person in sortYear) { Console.WriteLine(person.Name); }
            Console.WriteLine("-----------------------------------");
            var sortDeath = from s in stemPeople
                            where s.DeathYear > 1960 && s.DeathYear < 2015
                            orderby s.Name ascending
                select s;
            foreach(famousPeople people in sortYear) { Console.WriteLine(people.Name); }
        }
    }
}

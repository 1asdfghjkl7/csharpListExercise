using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> otherPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(otherPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            // foreach (string item in planetList)
            // {
            //     Console.WriteLine(item);
            // }
            List<string> rockyboi = planetList.GetRange(0, 4);
            // foreach (string item in rockyboi)
            // {
            //     Console.WriteLine(item);
            // }

            planetList.Remove("Pluto");
            // foreach (string item in planetList)
            // {
            //     Console.WriteLine(item);
            // }

            // Dictionary<string,string> stuff = new Dictionary<string,string>(){
            //     {"Pioneer 5", "asd"}
            // };
            List<Dictionary<string, string>> MyList = new List<Dictionary<string, string>>();

            Dictionary<string, string> Mercury = new Dictionary<string, string>() { { "Pioneer", "Mercury" }, { "MESSENGER", "Mercury" } };

            Dictionary<string, string> Venus = new Dictionary<string, string>() { { "Venera", "Venus" }, { "IKAROS", "Venus" } };

            Dictionary<string, string> Earth = new Dictionary<string, string>() { { "HiRise", "Earth" }, { "GEOS", "Earth" } };

            Dictionary<string, string> Mars = new Dictionary<string, string>() { { "Mars Global Surveyor", "Mars" }, { "InSight", "Mars" } };

            Dictionary<string, string> Jupiter = new Dictionary<string, string>() { { "Voyager 2", "Pioneer 10" }, { "Ulysses", "Jupiter" } };

            Dictionary<string, string> Saturn = new Dictionary<string, string>() { { "Cassini", "Saturn" }, { "Huygens", "Saturn" } };

            Dictionary<string, string> Neptune = new Dictionary<string, string>() { { "Voyager 1", "Neptune" } };

            Dictionary<string, string> Uranus = new Dictionary<string, string>() { { "Voyager 2", "Uranus" } };

            MyList.Add(Mercury);
            MyList.Add(Venus);
            MyList.Add(Earth);
            MyList.Add(Mars);
            MyList.Add(Jupiter);
            MyList.Add(Saturn);
            MyList.Add(Neptune);
            MyList.Add(Uranus);


            foreach (string planet in planetList)
            {
                List<string> completedList = new List<string>();
                foreach (Dictionary<string, string> item in MyList)
                {
                    foreach (KeyValuePair<string, string> stuff in item)
                    {
                        if (stuff.Value == planet)
                        {
                            completedList.Add(stuff.Key);
                        }
                        // Console.WriteLine(item);
                        // Console.WriteLine(stuff);

                    }

                }
                string completedString = string.Join(", ", completedList);
                Console.WriteLine("{0}: {1}", planet, completedString);
                // Console.WriteLine(planet);
            }


        }
    }
}

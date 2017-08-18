using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Delegates
    {
        public delegate int ExampleMethod(Animal animal);

        public Delegates(Animal [] animals)
        {
            string topAge = GetTopAnimals(animals, x=>x.age);
            string topName = GetTopAnimals(animals, x=>x.name.Length);
            Console.WriteLine("Longest name is : " + topName + " , and the best age is : " + topAge);
        }
        /*
        public int LongestName(Animal animal)
        {
            return animal.name.Length;
        }

        public int LongestAge(Animal animal)
        {
            return animal.age;
        }*/

        public string GetTopAnimals( Animal [] animals, ExampleMethod exampleCaller)
        {
            string name = "";
            int best = 0;
            foreach(Animal animal in animals)
            {
                int current = exampleCaller(animal);
                if (best < current)
                {
                    name = animal.name;
                    best = current;
                }
            }
            return name;
        }

        
        
        
    }
}

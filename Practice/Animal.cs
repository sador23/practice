using Practice.Design_Patterns.State;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Practice
{
    public class Animal
    {

        public string name;
        public int age;
        private static List<Animal> animals = new List<Animal>();
        private Ability ability;
        private static Random rand = new Random();

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            animals.Add(this);
            this.ability = rand.Next(3) == 1 ? new FireBreathing() : ability = new Normal();
        }

        public void GetAbility()
        {
            this.ability.AddAbility(name);
        }

        //Use [] indexer to access Animals
        public object this[int n] { get => animals[n]; 
                                    set { animals[n] =(Animal) value; } }
       
        //Override ToString
        public override string ToString()
        {
            string output = string.Format("This animal is a {0} and has age of {1}", name, age);
            return output;
        }
    }
}

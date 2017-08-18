﻿using Practice.Design_Patterns;
using Practice.Design_Patterns.Factory;
using Practice.Design_Patterns.Singleton;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE
            DelegateMethods();

            //LAMBDAS
            Lambdas lambdas = new Lambdas();

            //LINQ
            LinqMethods();

            //Factory Design Pattern
            FactoryDesign();

            //Singleton Design Pattern
            SingletonDesign();

        }

        static void LinqMethods()
        {
            Linq linq = new Linq();
            linq.GreaterThan(40);
            linq.GreaterThanLamdba(40);
            linq.getMax();
            linq.GetMaxLonger();
        }

        static void DelegateMethods()
        {
            Animal[] animals = new Animal[5] { new Animal("cat", 5), new Animal("hamster", 3), new Animal("parrot", 30), new Animal("snake", 15), new Animal("dog", 10) };
            Delegates delagates = new Delegates(animals);
            Animal cat = new Animal("catt", 11);
            Console.WriteLine(cat[1]);
        }

        static void FactoryDesign()
        {
            Console.WriteLine("Please enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter type of person");
            string person_type = Console.ReadLine();
            Person person = Factory.CreatePerson(person_type,username);
            Console.WriteLine(person);
        }

        static void SingletonDesign()
        {
            Admin admin = Admin.GetAdmin("John");
            Console.WriteLine(admin.name.Equals(Admin.GetAdmin("Hugh").name));
        }
    }
}
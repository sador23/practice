using Practice.Design_Patterns;
using Practice.Design_Patterns.Decorator;
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
            //DelegateMethods();

            //LAMBDAS
            //Lambdas lambdas = new Lambdas();

            //LINQ
            LinqMethods();

            //Factory Design Pattern
            //FactoryDesign();

            //Singleton Design Pattern
            //SingletonDesign();

            //State Design Pattern
            //StatePattern();

            //Decorator Design Pattern
            //DecoratorDesign();

        }

        static void LinqMethods()
        {
            Animal[] animals = new Animal[5] { new Animal("cat", 5), new Animal("hamster", 3), new Animal("parrot", 30), new Animal("snake", 15), new Animal("dog", 10) };
            Linq linq = new Linq();
            //linq.GreaterThan(40);
            //linq.GreaterThanLamdba(40);
            //linq.getMax();
            //linq.GetMaxLonger();
            //linq.GroupByLinq(animals);
            //linq.LinqToXML(animals);
            //linq.OperationOnSource();
            linq.Identifier(animals);
            linq.SelectIdentifierNew(animals);

        }

        static void StatePattern()
        {
            Animal[] animals = new Animal[5] { new Animal("cat", 5), new Animal("hamster", 3), new Animal("parrot", 30), new Animal("snake", 15), new Animal("dog", 10) };
            foreach(Animal animal in animals)
            {
                animal.GetAbility();
            }
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

        static void DecoratorDesign()
        {
            Manager manager = new Manager("John");
            Console.WriteLine(manager);
            YearlyBonusDecorator yearly = new YearlyBonusDecorator(manager.name,manager);
            Console.WriteLine(yearly);
            AwardBonusDecorator award = new AwardBonusDecorator(yearly.name, yearly);
            Console.WriteLine(award);
        }
    }
}
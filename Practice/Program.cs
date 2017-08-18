using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE
            Animal[] animals = new Animal[5] { new Animal("cat", 5), new Animal("hamster", 3), new Animal("parrot", 30), new Animal("snake", 15), new Animal("dog", 10)};
            Delegates delagates = new Delegates(animals);
            Animal cat = new Animal("catt", 11);
            Console.WriteLine(cat[1]);

            //LAMBDAS
            Lambdas lambdas = new Lambdas();
            
            //LINQ
            Linq linq = new Linq();
            linq.GreaterThan(40);

            linq.GreaterThanLamdba(40);
            linq.getMax();
            linq.GetMaxLonger();

            
        }
    }
}
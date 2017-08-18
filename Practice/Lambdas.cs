using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Lambdas
    {
        delegate int lamdaDelegate(int x);
        //Lambdas can be used a lot in linq, but also anywhere a delegate is expected!
        public Lambdas()
        {
            int i = 12;
            //lambda can see i
            lamdaDelegate lambdaDel = x => x * i;
            Console.WriteLine(lambdaDel.Invoke(5));

            //Lambda with Query
            Animal[] animals = new Animal[5] { new Animal("cat", 5), new Animal("hamster", 3), new Animal("parrot", 30), new Animal("snake", 15), new Animal("dog", 10) };
            var query = animals.Where(x => x.age > 10);
            Console.WriteLine("Animals with age higher than 10");
            foreach(Animal animal in query)
            {
                Console.WriteLine(animal.name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns.State
{
    public class Normal : Ability
    {
        public void AddAbility(string name)
        {
            Console.WriteLine(name + " is now without ability");
        }
    }
}

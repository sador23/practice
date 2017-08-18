using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns.Factory
{
    public class Factory
    {

        //Creates Person runtime, according to the correct input
        public static Person CreatePerson(string person_type, string name)
        {
            switch (person_type)
            {
                case "Employee": return new Employee(name);
                case "Manager": return new Manager(name);
                default: return null;
            }

        }
    }
}

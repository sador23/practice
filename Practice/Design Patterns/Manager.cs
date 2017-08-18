using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns
{
    class Manager : Person
    {
        public Manager(string name) : base(name)
        {
            this.salary = 3000;
        }

       
    }
}

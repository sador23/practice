using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns.Decorator
{
    public class AwardBonusDecorator : Decorator
    {
        public AwardBonusDecorator(string name, Person person) : base(name, person)
        {
            this.person = person;
            
        }

        public override int GetSalary()
        {
            return (int)(person.salary * 1.1);
        }
    }
}

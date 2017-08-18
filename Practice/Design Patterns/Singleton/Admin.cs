using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns.Singleton
{
    public class Admin : Person
    {
        //Not the best idea to make Admin a singleton, it's only for trying out the Design Pattern

        private static Admin _instance = null;
        
        private Admin(string name ) : base(name)
        {

        }

        public static Admin GetAdmin(string name)
        {
            if (_instance == null)
            {
                _instance = new Admin(name);
                return _instance;
            }
            return _instance;
        }


    }
}

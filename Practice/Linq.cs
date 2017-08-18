﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    public class Linq
    {
        public int[] numbers { get; set; }

        public Linq()
        {
            numbers = new int[] { 1, 6, 10,5,9,22,32,78,21,68,65,34,26,89 };
        }

        //Select every number from numbers, which are greater than n
        public void GreaterThan(int n)
        {
            Console.WriteLine("Method for selescting every item greater than " + n);
            var greater = from num in numbers
                          where num > n
                          select num;
            ConsoleWriter(greater);
            
        }
        //Select every number from numbers with LAMBDA, which are greater than n
        public void GreaterThanLamdba(int n)
        {
            Console.WriteLine("Method for selescting with LAMBDA every item greater than " + n);
            var greater = numbers.Where(x => x > n);
            ConsoleWriter(greater);
        }

        //Select max from list One Liner
        public void getMax()
        {
            var max = numbers.Max();
            Console.WriteLine("Max number is : " + max);
        }

        public void GetMaxLonger()
        {
            var max = numbers.OrderByDescending(x => x).First();
            //For limit use .Take(n)
            // If you want to skip 10, and then take the first 30 .Skip(10).Take(30);
            Console.WriteLine("Max number is : " + max);
        }



        public void ConsoleWriter(IEnumerable<int> numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
    }
}
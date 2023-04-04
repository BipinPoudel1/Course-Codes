using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAndAsync
{
    internal class Animal
    {
        public void WhatIEat()
        {
            Console.WriteLine("I eat grass.");
        }

        public void WhatIEat(string food)
        {
            Console.WriteLine("I eat " + food);
        }

        public void func1()
        {
            Console.WriteLine("Func1");
        }
    }
}

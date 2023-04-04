 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAndAsync
{
     class Program
    {
        //public static void function1()
        //{
        //    for(int counter=0; counter<=50; counter++)
        //    {
        //        Console.WriteLine("I am from function1");
        //    }
        //}

        //public static async void Function2()
        //{
        //    await Task.Run(() =>
        //    {
        //        for(int i=0; i<=50; i++)
        //        {
        //            Console.WriteLine("I am from function 2");
        //        }
        //    });
        //}


        //Deligate
        public delegate void WhatToEat();
        public delegate void WhatToEats(string food);
        static void Main(string[] args)
        {
            //Function2();
            //function1();
            Animal cow = new Animal();
            WhatToEat eat = new WhatToEat(cow.WhatIEat);
            eat += cow.func1;
            WhatToEats eats = new WhatToEats(cow.WhatIEat);

            eat();
            eats("straw.");

            Console.ReadKey();
        }
    }
}

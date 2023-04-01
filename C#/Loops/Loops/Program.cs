using System;

namespace Loops
{
    internal class Program
    {
        //For loop to print first five numbers
        static void forLoop()
        {
            int i = 1;
            for (; i <= 5;)
            {
                Console.WriteLine(i);
                i++;
                
            }
        }

        //for each loop to print all the elements of an array
        static void foreachloop()
        {
            string[] country = { "Nepal", "USA", "India", "China" };
            foreach (string x in country)
            {
                Console.Write(x + "\t");
            }
        }

        //while loop to print from 1 to 5
        static void whileLoop()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.Write(i + "\t");
                i++;
            }
        }

        //do- while loop to print from 1 to 5
        static void doWhileLoop()
        {
            int x = 0;
            do
            {
                Console.Write("x= " + x + "\t");
                x++;
            } while (x <= 5);
        }
        static void Main(string[] args)
        {
            //forLoop();
            //foreachloop();
            //whileLoop();
            doWhileLoop();
            Console.ReadKey();
        }
    }
}

using System;

namespace Generics
{
    internal class Program
    {
        class Example
        {
            public static void ShowArray<T>(T[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            public static bool Check<T>(T a, T b)
            {
                bool c = a.Equals(b);
                return c;
            }
        }
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 11;
            Numbers[1] = 22;
            Numbers[2] = 33;

            string[] Names = { "Bipin", "Rebeca", "Laura" };
            double[] Pints = { 2.3, 4.6, 2.4 };

            Example.ShowArray(Numbers);
            Console.WriteLine("_____________________________");
            Example.ShowArray(Names);
            Console.WriteLine("_____________________________");
            Example.ShowArray(Pints);
            Console.WriteLine("_____________________________");

            Console.WriteLine(Example.Check(10, 20));
            Console.WriteLine(Example.Check("Leela", "Leela"));
            Console.WriteLine(Example.Check('A', 'B'));
            Console.ReadKey();
        }
    }
}

using System;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operator");
            int a = 7, b = 10;
            Console.WriteLine("For A=7 and B=10");
            Console.WriteLine("```````````````````");
            Console.WriteLine("Addition: A + B = " + (a + b));
            Console.WriteLine("Subtraction: A - B = " + (a - b));
            Console.WriteLine("Multiplication: A * B = " + (a * b));
            Console.WriteLine("Division: B / A = {0}", (double)b / a);
            Console.WriteLine("Remainder: A % B = " + (a % b));
            Console.WriteLine("Increment: A++ = {0}", a++); //Post Increment
            Console.WriteLine("Decrement: B-- = " + --b);   //Pre Decrement
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Calculation(int a, int b);
    internal class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result= " + result);
        }

        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction Result= " + result);
        }

        public static void Multiplicatin(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result= " + result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result= " + result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);
            obj.Invoke(20, 10);
            obj=Subtraction;
            obj(20, 10);
            obj = Multiplicatin;
            obj(2, 4);

            Calculation obj1 = new Calculation(Program.Division);
            obj1(10, 5);
            Console.ReadKey();
        }
    }
}

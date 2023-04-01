using System;

namespace Operators
{
    internal class Program
    {
        //Function to compare the given numbers.
        static void compare(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Given numbers are equal.");
            }else if(a < b)
            {
                Console.WriteLine("{0} is less than {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", a, b);
            }
        }

        //Function for Logical Operator (Also includes conditional statements)
        static void logical()
        {
            string college;
            string program;
            Console.WriteLine("Entrance of Library");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            Console.Write("Enter your college Name: ");
            college = Console.ReadLine();
            Console.Write("Enter your program: ");
            program = Console.ReadLine();

            if(college== "BMC" && program=="CSIT")
            {
                Console.WriteLine("Welcome to the Library.");
            }else if (college=="BMC" && program != "CSIT")
            {
                Console.WriteLine("You can only visit college premise.");
            }else
            {
                Console.WriteLine("Permission denied.");
            }
        }

        static void bitwiseOperations()
        {
            Console.WriteLine("Bitwise Operations");
            Console.WriteLine("###################");
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
            Console.WriteLine("{0} & {1} = {2}", a, b, a & b);
            Console.WriteLine("~{0} = {1}", a, ~a);
            Console.WriteLine("{0} << 1 = {1}", a, a << 1);
            Console.WriteLine("{0} >> 2 = {1}", a, a >> 2);

        }
        static void Main(string[] args)
        {
            //compare(4, 7);
            logical();
            //bitwiseOperations();
            Console.ReadKey();
        }
    }
}

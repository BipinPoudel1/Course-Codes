using System;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            try {
                int result = num1 / num2;
                Console.WriteLine("Result= " + result);
            }
            catch(DivideByZeroException ex)
            {
                //Console.WriteLine("You cannot divide a number by 0.");
                Console.WriteLine(ex.Message);
            }
            

            Console.WriteLine("Remaining Statement 1");
            Console.WriteLine("Remaining Statement 2");
            Console.WriteLine("Remaining Statement 3");

            Console.ReadKey();
        }
    }
}

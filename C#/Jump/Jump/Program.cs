using System;

namespace Jump
{
    internal class Program
    {
        static void jump_goto()
        {
            Console.WriteLine("Jump: Goto statement");
            goto g;
            Console.WriteLine("This line will not be printed on console.");

        g:
            {
                Console.WriteLine("I jumped to this line.");
            }
        }

        static void jump_break()
        {
            for(int i=1; i<=6; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine("Hello World " + i);
            }
        }

        static void jump_continue()
        {
            for(int j=1; j<=6; j++)
            {
                if (j == 4)
                    continue;
                Console.WriteLine("Hello World " + j);
            }
        }
        static void Main(string[] args)
        {
           // jump_goto();
            //jump_break();
            jump_continue();
            Console.ReadKey();
        }
    }
}

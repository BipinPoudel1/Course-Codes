using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IEmployee
    {
        void show();
    }

    class PartTimeEmplyees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is a method of IEmployee interface.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmplyees pte = new PartTimeEmplyees();
            pte.show();

            Console.ReadKey();
        }
    }
}

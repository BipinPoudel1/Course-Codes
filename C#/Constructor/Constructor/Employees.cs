using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employees
    {
        int EmpId;
        string EmpName;
        int EmpAge;

        public Employees()        //Default constructor (have no paramater)
        {
            Console.WriteLine("This is a first constructor...");
        }

        ~Employees()
        {
            Console.WriteLine("Destructor is called.");
        }




        public Employees(int EmpId, string EmpName, int EmpAge) //Parameterized Constructor
        {
            this.EmpId= EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
            Console.WriteLine("This is a third Constructor.");
        }

        public Employees (int EmpID, string EmpName)
        {
            Console.WriteLine("This is 2nd constructor.");
        }

       
        static void Main(string[] args)
        {

            Employees p = new Employees();
            Employees q = new Employees(101, "Bipin");
            Employees r = new Employees(102, "Steve", 45);


            Console.ReadKey();
        }
    }
}

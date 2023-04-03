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

        public int getID()
        {
            return this.EmpId;
        }
        public string getName()
        {
            return this.EmpName;
        }
        public int getAge()
        {
            return this.EmpAge;
        }
        static void Main(string[] args)
        {
            //Employees p = new Employees(111, "Stark", 35);      //Constructor is called whenever an object is created.
            //Employees e = new Employees(112, "Steve", 45);

            //Console.WriteLine("ID = "+p.getID());
            //Console.WriteLine("Name = " + p.getName());
            //Console.WriteLine("Age = " + p.getAge());
            //Console.WriteLine("****************************");
            //Console.WriteLine("ID = " + e.getID());
            //Console.WriteLine("Name = " + e.getName());
            //Console.WriteLine("Age = " + e.getAge());

            Employees p = new Employees();
            Employees q = new Employees(101, "Bipin");
            Employees r = new Employees(102, "Steve", 45);



            Console.ReadKey();
        }
    }
}

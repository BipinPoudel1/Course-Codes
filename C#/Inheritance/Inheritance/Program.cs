using System;

namespace Inheritance
{
    class VisitingEmployees : Employees
    {
        public int VisitingSalary;
        public int VisitingHours;
    }

    class PermanentEmployees : Employees
    {
        public int PermanentSalary;
        public int PermanentHours;
    }

    class Employees
    {
        public int EmpID;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;

        public void show()
        {
            Console.WriteLine("This is a method of a parent (base) class.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployees Bipin = new PermanentEmployees();
            Bipin.EmpID = 12;
            Bipin.show();

            VisitingEmployees Jonna = new VisitingEmployees();
            Jonna.EmpID = 23;

            Console.WriteLine("ID: " + Bipin.EmpID);
            Console.WriteLine("ID: " + Jonna.EmpID);

            Console.ReadKey();
        }
    }
}

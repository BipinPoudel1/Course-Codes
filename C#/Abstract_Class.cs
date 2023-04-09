using System;

namespace Abstract_Class
{
    public abstract class person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string ContactNumber;

        public abstract void PrintDetails();
    }

    class student: person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Age of Student: " + this.Age);
            Console.WriteLine("Contact Number of Student: " + this.ContactNumber);
            Console.WriteLine("Student Roll Number: " + this.RollNo);
            Console.WriteLine("Student Fees: " + this.Fees);

        }
    }

    class professor: person
    {
        public string Qualification;
        public int Salary;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Professor's Name: " + name);
            Console.WriteLine("Professor's Age: " + this.Age);
            Console.WriteLine("Professor's Contact Number: " + this.ContactNumber);
            Console.WriteLine("Qualification: " + this.Qualification);
            Console.WriteLine("Salary: " + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student Bipin = new student();
            Bipin.FirstName = "Bipin";
            Bipin.LastName = "Poudel";
            Bipin.Age = 21;
            Bipin.ContactNumber = "9876543210";
            Bipin.RollNo = 18;
            Bipin.Fees = 50000;
            Bipin.PrintDetails();

            Console.WriteLine("------------------------------");

            professor Aishwariya = new professor();
            Aishwariya.FirstName = "Aishwariya";
            Aishwariya.LastName = "Rai";
            Aishwariya.Age = 49;
            Aishwariya.ContactNumber = "9801234567";
            Aishwariya.Qualification = "M. Arch";
            Aishwariya.Salary = 2900000;
            Aishwariya.PrintDetails();

            Console.ReadKey();
        }
    }
}

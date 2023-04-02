using System;

namespace ClassesAndObjects
{
    internal class Student
    {
        int rollNo;
        string name;
        int age;

        public void setStudent(int rollNo, string name, int age)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.age = age;
        }

        public void getStudent()
        {
            Console.WriteLine("Roll No.: " + this.rollNo);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your Roll No. ");
            int roll=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int ag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Student Bipin = new Student();
            Bipin.setStudent(roll, name, ag);

            Student Aruna = new Student();
            Aruna.setStudent(1, "Aruna", 22);
            
            Aruna.getStudent();

            Bipin.getStudent();
            Console.ReadKey();
            
        }
    }
}

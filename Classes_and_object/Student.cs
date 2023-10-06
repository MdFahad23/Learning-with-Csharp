using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_object
{
    internal class Student
    {
        int rollNo;
        string studentName;
        int age;
        int standert;

        public void setStudnet(int rollNo, string studentName, int age, int standert) {
            this.rollNo = rollNo;
            this.studentName = studentName;
            this.age = age;
            this.standert = standert;
        }

        public void getStudent()
        {
            Console.WriteLine("Student Roll Number: {0}", this.rollNo);
            Console.WriteLine("Student Name: {0}", this.studentName);
            Console.WriteLine("Student Age: {0}", this.age);
            Console.WriteLine("Student Class: {0}", this.standert);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Roll: ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Class: ");
            int standert = int.Parse(Console.ReadLine());

            Student Hasan = new Student();
            Hasan.setStudnet(rollNo, studentName, age, standert);
            Hasan.getStudent();



            Console.ReadLine();
        }
    }
}

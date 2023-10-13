using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int age;
        public string _phoneNumber;
        public static string Instuted = "Ayub Fondation Technical Collage";

        public string phoneNumber {
            set
            {
                _phoneNumber = value;
            }
            get
            {
                return _phoneNumber;
            }
        }

        public abstract void PrintDetails();
    }

    class Studnet : Person
    {
        public int RoolNo;
        public int fee;

        public override void PrintDetails()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Student fullName is {0}", fullName);
            Console.WriteLine("Student age is {0}", age);
            Console.WriteLine("Student Phone Number is {0}", phoneNumber);
            Console.WriteLine("Student Rool No is {0}", RoolNo);
            Console.WriteLine("Student fee is {0}", fee);
            Console.WriteLine(Instuted);
        }
    }

    class Teacher : Person
    {
        public string qualification;
        public int salary;

        public override void PrintDetails()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Teacher fullName is {0}", fullName);
            Console.WriteLine("Teacher age is {0}", age);
            Console.WriteLine("Teacher Phone Number is {0}", phoneNumber);
            Console.WriteLine("Teacher Qualification is {0}", qualification);
            Console.WriteLine("Teacher salary is {0}", salary);
            Console.WriteLine(Instuted);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student
            Studnet ali = new Studnet();
            ali.FirstName = "Mohammad";
            ali.LastName = "Ali";
            ali.age = 22;
            ali.phoneNumber = "01891508667";
            ali.RoolNo = 1;
            ali.fee = 5120;
            ali.PrintDetails();

            Console.WriteLine("-----------------------------");

            //Teacher
            Teacher Hasan = new Teacher();
            Hasan.FirstName = "Mohammad";
            Hasan.LastName = "Hasan";
            Hasan.age = 30;
            Hasan.phoneNumber = "01587945615";
            Hasan.qualification = " Mastars Of Computer Scinche";
            Hasan.salary = 50000;
            Hasan.PrintDetails();



            Console.ReadLine();
        }
    }
}

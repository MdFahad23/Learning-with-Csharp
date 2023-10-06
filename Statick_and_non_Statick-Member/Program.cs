using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statick_and_non_Statick_Member
{
    class Student
    {
        public int rollNom;
        public string firstName;
        public string lastName;
        public int standert;
        public static string SchoolName = "Ayub Foundation Technical School And Collage";
        public static int fees = 4000;

        public void printFullName()
        {
            string fullName = firstName + " " + this.lastName;
            Console.WriteLine("Your full Name is {0}", fullName);
        }

        public static int setFees()
        {
            return fees;
        }

        public static int discountFees(int fee) {
            return fees / fee;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Adil = new Student();
            Student Akil = new Student();
            
            /*Adil Data*/
            Adil.rollNom = 11;
            Adil.firstName = "Mohammad";
            Adil.lastName = "Adil";
            Adil.standert = 12;
            /*Akil Data*/
            Akil.rollNom = 22;
            Akil.firstName = "Akil";
            Akil.lastName = "Sharma";
            Akil.standert = 10;

            Console.WriteLine(Adil.rollNom);
            Console.WriteLine(Adil.firstName);
            Console.WriteLine(Adil.lastName);
            Console.WriteLine(Adil.standert);
            Adil.printFullName();
            Console.WriteLine(Student.SchoolName);
            Console.WriteLine(Student.setFees());
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Akil.rollNom);
            Console.WriteLine(Akil.firstName);
            Console.WriteLine(Akil.lastName);
            Console.WriteLine(Akil.standert);
            Akil.printFullName();
            Console.WriteLine(Student.SchoolName);
            Console.WriteLine(Student.setFees());
            Console.WriteLine(Student.discountFees(10));




            Console.ReadLine();

        }
    }
}

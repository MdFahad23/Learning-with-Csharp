using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Properties
{
    abstract class Person
    {
        public abstract uint Id { get; set; }
        public abstract string Name { get; set; }
    }

    class Student : Person
    {
        public uint StudentId;
        public string StudentName;
        public override uint Id {
            set {
                if(value != 0)
                {
                    StudentId = value;
                }
                else
                {
                    Console.WriteLine("Zero is Not Valid ID!!");
                }
            }
            get {
               return StudentId;
            }
        }

        public override string Name { 
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    StudentName = value;
                }
                else
                {
                    Console.WriteLine("Enter the Valid Name!!");
                }
            }
            get => StudentName; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Ashif = new Student();
            Ashif.Id = 15;
            Ashif.Name = "Ashif Khan";
            Console.WriteLine(Ashif.Id);
            Console.WriteLine(Ashif.Name);

            Console.ReadLine();
        }
    }
}

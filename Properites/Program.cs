using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properites
{
    class Student
    {
        private int _StuId;
        private string _Name;
        private string _Fname;
        private int _subjectTotalMarks = 1024;

        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Student(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public int StuId
        {
            set
            {
                if (value >= 0)
                {
                    _StuId = value;
                }
                else
                {
                    Console.WriteLine("Invalide Value");
                }
            }
            get
            {
                return _StuId;
            }
        }

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("Invalide Name");
                }
            }
            get
            {
                return _Name;
            }
        }

        public string Fname
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Fname = value;
                }
                else
                {
                    Console.WriteLine("Invalide Father Name");
                }
            }
            get
            {
                return _Fname;
            }
        }

        public int SubjectTotalMarks
        {
            get
            {
                return _subjectTotalMarks;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Md", "Fahad");
            s1.StuId = 10;
            s1.Name = "Fahad";
            s1.Fname = "Faruk Ahmed";
            Console.WriteLine(s1.StuId);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Fname);
            Console.WriteLine(s1.SubjectTotalMarks);
            Console.WriteLine(s1.firstName);
            Console.WriteLine(s1.lastName);

            Console.ReadLine();
        }
    }
}

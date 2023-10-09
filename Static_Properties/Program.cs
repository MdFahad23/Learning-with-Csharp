using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Properties
{
    class University
    {
        static string UniversityName;
        static string UniversityDepertmentName;

        public static string _UniversityName
        {
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    UniversityName = value;
                }
                else
                {
                    Console.WriteLine("Please not submit emty value or null value!!");
                }
            }

            get {
                return UniversityName;
            }
        }

        public static string _UniversityDepertmentName
        {
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    UniversityDepertmentName = value;
                }
                else
                {
                    Console.WriteLine("Please not submit emty value or null value!!");
                }
            }

            get
            {
                return UniversityDepertmentName;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            University._UniversityName = "Dhaka University";
            University._UniversityDepertmentName = "Computer Enginnering";
            Console.WriteLine("This university name is {0}", University._UniversityName);
            Console.WriteLine("This university depertment name is {0}", University._UniversityDepertmentName);

            Console.ReadLine();
        }
    }
}

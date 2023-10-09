using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name: ");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            String LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Show this name: " + FirstName + " " + LastName);
            Console.WriteLine("Show this name: {0} {1} {2}", FirstName, LastName, Age);
            Console.ReadLine();
        }
    }
}

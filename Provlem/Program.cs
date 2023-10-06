using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provlem
{
    internal class Program
    {

        //Calculator Application Methods
        public static void Addation(int num1, int num2)
        {
            Console.WriteLine("Addation Number: {0} {1}",  num2 + num2);
        }

        public static void Subscripation(int num1, int num2)
        {
            Console.WriteLine("Subscripation Number: {0} {1}", num2 - num2);
        }

        public static void Multiplaction(int num1, int num2)
        {
            Console.WriteLine("Multiplaction Number: {0} {1}", num2 * num2);
        }

        public static void Devison(int num1, int num2)
        {
            Console.WriteLine("Devison Number: {0} {1}", num2 / num2);
        }

        static void Main(string[] args)
        {
            /*Check the number Even or odd*/
            /*Console.WriteLine("Enter the Number: ");
            int num1 = int.Parse(Console.ReadLine());
            int sum1 = num1 % 2 == 0 ? "Even Number" : "Odd Number";

            Console.WriteLine("Odd Number: {0}", sum1);*/

            /*Authentication System*/
            /*Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Registation Successfully! Please, You are Login Now?");
            Console.WriteLine("Enter Your Email: ");
            string loginEmail = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string loginPassword = Console.ReadLine();

            if (email == loginEmail && password == loginPassword) {
                Console.WriteLine("Login Successfully!");
            }
            else
            {
                Console.WriteLine("Login Faild!");
            }*/

            //How to Creat Claculator Application
            Console.WriteLine("Enter Your First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator (+, -, *, /)");
            char op = Console.ReadLine();

            if (op.Equals("+")) {
                Program.Addation(num1, num2);
            }else if (op.Equals("-"))
            {
                Program.Subscripation(num1, num2);
            }else if (op.Equals("*"))
            {
                Program.Multiplaction(num1, num2);
            }else if (op.Equals("/"))
            {
                Program.Devison(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalide Data !!");
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeOrFunction
{
    internal class Program
    {

        public void show() //Declaring a method // non-static // instance method
        {
            Console.WriteLine("Welcome to C# Programe! non-static Method Call by reprance object");
        }

        public static void show1()
        {
            Console.WriteLine("Welcome to C# Programe! Static Methode Call by reperance Programe.");
        }

        public static void add(int num1, int num2)
        {
            int resutl = num1 + num2;
            Console.WriteLine("Addtional Number: " + resutl);
        }

        public static int getAdditonNumber(int num1, int num2) {
            return num1 + num2;
        }


        //Calculator Application Methods
        public static void Addation(int num1, int num2)
        {
            int result = num2 + num2;
            Console.WriteLine("Addation Number: {0}", result);
        }

        public static void Subscripation(int num1, int num2)
        {
            int result = num2 - num2;
            Console.WriteLine("Subscripation Number: {0}", result);
        }

        public static void Multiplaction(int num1, int num2)
        {
            int result = num2 * num2;
            Console.WriteLine("Multiplaction Number: {0}", result);
        }

        public static void Devison(int num1, int num2)
        {
            int result = num2 / num2;
            Console.WriteLine("Devison Number: {0}", result);
        }


        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.show();

            Program.show1();

            Program.add(20, 65);

            Console.WriteLine(Program.getAdditonNumber(758, 6548));

            //How to Creat Claculator Application
            Console.WriteLine("Enter Your First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator (+, -, *, /)");
            string op = Console.ReadLine();

            if (op.Equals("+"))
            {
                Program.Addation(num1, num2);
            }
            else if (op.Equals("-"))
            {
                Program.Subscripation(num1, num2);
            }
            else if (op.Equals("*"))
            {
                Program.Multiplaction(num1, num2);
            }
            else if (op.Equals("/"))
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

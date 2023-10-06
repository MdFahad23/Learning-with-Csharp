using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Number: " + i);
            }*/

            /*Console.WriteLine("Enter Your Number: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine( number + " X " + i + " = " + number*i );
            }*/

            /*int number = 2;
            int i = 1;

            while(i < 10)
            {
                Console.WriteLine(number + " X " + i + " = " + number*i);
                i++;
            }*/

            /*
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 0);*/

            /*Restart Progrma*/


            string confirm;

            /*do
            {
                Console.WriteLine("Enter your first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int sum = num1 + num2;
                Console.WriteLine("Addation your number: " + sum);
                Console.WriteLine("Restar your program? yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");*/

            while (true) {
                Console.WriteLine("Enter your first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int sum = num1 + num2;
                Console.WriteLine("Addation your number: " + sum);
                Console.WriteLine("Restar your program? yes/no");
                confirm = Console.ReadLine().ToLower();
                if (confirm == "yes") {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Exit the loop...");




            Console.ReadLine();
        }
    }
}

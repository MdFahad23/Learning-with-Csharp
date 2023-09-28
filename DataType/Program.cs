using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataType
{
    internal class Program
    {
        public const string name = "Md Fahad";
        static void Main(string[] args)
        {
            Console.WriteLine(name);
            Console.ReadLine();

            // Data Type Size Check
            // Console.WriteLine(int.MaxValue);
            // Console.WriteLine(int.MinValue);

            // Float Double and Decimal
            //float f = 102.1025694568f; // f - Prefix
            //double d = 123456789.123456789d; // d - prefix
            //decimal m = 123456789.123456789m; // m - prefix

            // Console.WriteLine(m);

            // String and Character Data Type

            //string st = "Welcome to C#";
            //char cr = 'b';

            //string sequence = "\tHello";
            //string sequence = "\"Hello\"";
            //string sequence = "One\nTwo\nThree";
            //string sequence = "D:\\Program\\C#";
            //string sequence = @"D:\Program\C#";

            // Console.WriteLine(sequence);

            // Conversion DataType
            //string num1 = "50";
            //string num2 = "70";

            //nt sum = int.Parse(num1) + int.Parse(num2);

            // Console.WriteLine(sum);

            // Simple Optation Program
            //int a = 30;
            //int b = 60;

            //bool c = a > b;
            //bool c = b > a;
            //bool c = a == b;
            // Console.WriteLine(c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadFunction
{
    public delegate void LambadExpression(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            LambadExpression obj = (a) =>
            {
                a += 20;
                Console.WriteLine(a);
            };
            obj(10);

            Console.ReadLine();
        }
    }
}

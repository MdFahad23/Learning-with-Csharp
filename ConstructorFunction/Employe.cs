using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorFunction
{
    internal class Employe
    {
        int EmpId;
        string EmpName;
        int EmpAge;
        public Employe(int empId, string empName, int empAge)
        {
            EmpId = empId;
            EmpName = empName;
            EmpAge = empAge;
        }

        public int getEmpId()
        {
            return EmpId;
        }
        public string getEmpName()
        {
            return EmpName;
        }
        public int getEmpAge()
        {
            return EmpAge;
        }


        static void Main(string[] args)
        {
            Employe Ali = new Employe(59, "Ali Khan", 22);
            Employe Hasan = new Employe(69, "Hasan", 35);

            Console.WriteLine("Employ Id: {0}", Ali.getEmpId());
            Console.WriteLine("Employ Name: {0}", Ali.getEmpName());
            Console.WriteLine("Employ Age: {0}", Ali.getEmpAge());

            Console.WriteLine("------------------------------");

            Console.WriteLine("Employ Id: {0}", Hasan.getEmpId());
            Console.WriteLine("Employ Name: {0}", Hasan.getEmpName());
            Console.WriteLine("Employ Age: {0}", Hasan.getEmpAge());


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    class Employ
    {
        public int EmpID;
        public string EmpName;
        public double EmpGrosspay;
        double TextDuraction = 0.1;
        double netSalary;

        public Employ(int Eid, string Ename, double Egrosspay) { 
            this.EmpID = Eid;
            this.EmpName = Ename;
            this.EmpGrosspay = Egrosspay;
        }

        void CalculateSalaery()
        {
            if (EmpGrosspay >= 30000) {
                netSalary = EmpGrosspay - (TextDuraction * EmpGrosspay);
                Console.WriteLine("Your Id is {0}", EmpID);
                Console.WriteLine("Your Name is {0}", EmpName);
                Console.WriteLine("Your Salary is {0}", netSalary);
            }
            else
            {
                Console.WriteLine("Your Id is {0}", EmpID);
                Console.WriteLine("Your Name is {0}", EmpName);
                Console.WriteLine("Your Salary is {0}", EmpGrosspay);
            }
        }

        public void ShowEmpDetails()
        {
            CalculateSalaery();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ ali = new Employ(455, "Ali Hasan", 20000);
            ali.ShowEmpDetails();

            Console.ReadLine();
        }
    }
}

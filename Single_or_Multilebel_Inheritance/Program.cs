using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Single_or_Multilebel_Inheritance
{
    class Employes
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContact;

        public void getEmployId()
        {
            Console.WriteLine("Visiting Employe Id is {0}", EmpId);
        }
    }

    class PermanateEmploye : Employes
    {
        public int PermanateEmpSallery;
        public int PermanateEmpHours;
    }

    class VisitingEmploye : Employes {
        public int VisitingEmpSallery;
        public int VisitingEmpHours;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PermanateEmploye ali = new PermanateEmploye();
            VisitingEmploye Hasan = new VisitingEmploye();
            ali.EmpId = 1;
            ali.getEmployId();
            Hasan.EmpId = 25;
            Hasan.getEmployId();


            Console.ReadLine();
        }
    }
}

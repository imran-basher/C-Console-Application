using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009_SalaryWithBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            double SellerSalary, TotalSold, Salary;

             FirstName = Console.ReadLine();
             SellerSalary = Convert.ToDouble(Console.ReadLine());
             TotalSold = Convert.ToDouble(Console.ReadLine());

             Salary = (TotalSold * 15 / 100) + SellerSalary;

            Console.WriteLine("TOTAL = R$ {0}\n",Math.Round(Salary, 2, MidpointRounding.ToEven));


            Console.ReadLine();
        }
    }
}

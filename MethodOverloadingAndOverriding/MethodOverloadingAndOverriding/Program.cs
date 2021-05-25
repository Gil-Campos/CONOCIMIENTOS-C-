using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAndOverriding
{
    class Calculator
    {
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public int add(int num1, int num2, int num3)
        {
            return num1 + num2;
        }
    }

    class Employee
    {
        public double baseSalary; 

        public virtual double CalculateSalary()
        {
            return baseSalary;
        }
    }

    class SalesEmployee : Employee
    {
        public double salesBonus;

        public override double CalculateSalary()
        {
            return baseSalary + salesBonus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calc = new Calculator();

            //Console.WriteLine(calc.add(1, 2));
            //Console.WriteLine(calc.add(3.4, 5.78));
            //Console.WriteLine(calc.add(3, 6, 7));

            Employee baseEmp = new Employee();
            baseEmp.baseSalary = 1500;  
            Console.WriteLine(baseEmp.CalculateSalary());
            Console.WriteLine();

            SalesEmployee emp = new SalesEmployee();
            emp.baseSalary = 1500;
            emp.salesBonus = 300;

            Console.WriteLine(emp.CalculateSalary());

            Console.ReadKey();
        }
    }
}

using System;

namespace WithoutEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee();
            int a = Employee.Id = 1;
            string b = Employee.Name = "abhay";
            int c = Employee.Salary = 10000;
            Console.WriteLine(a + " " + b + " " + c);
        }
    }
}

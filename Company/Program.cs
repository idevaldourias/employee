using Company.Entities;
using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                
                Console.Write("Outsourced (y/n)? ");
                char test = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());

                if (test == 'y' || test == 'Y' )
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());

                    OutsourcedEmployee outemployee = new OutsourcedEmployee(name, hours, valueHour, addCharge);
                    employees.Add(outemployee);
                } 
                else
                {
                    Employee employee = new Employee(name, hours, valueHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
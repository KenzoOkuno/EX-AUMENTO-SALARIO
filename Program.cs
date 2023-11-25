
using PrimeiroProjetos;
using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("How many employees will be regitered?");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee # " + i);
                Console.Write("ID : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Salary : ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine("");
            }
            Console.Write("Enter the ID of the employee that will have a salary increase : ");
            int id1 = int.Parse(Console.ReadLine());
           Employee emp = list.Find(x => x.Id == id1);
            if(emp != null)
            {
                Console.WriteLine("Enter the percentage : ");
                double percent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);

            }
            else
            {
                Console.WriteLine("That ID is incorrect! ");
            }
            Console.WriteLine("");
            Console.WriteLine("Updated list of employees :");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

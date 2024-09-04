using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string job;
            int salary;

            Console.WriteLine("Enter Employee ID :");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Enployee job:");
            job = Console.ReadLine();

            Console.WriteLine("Enter Enployee Salary:");
            salary=int.Parse(Console.ReadLine());

            Console.WriteLine("Employee Id :" +id);
            Console.WriteLine("Employee Name :"+ name);
            Console.WriteLine("Employee Job :"+ job);
            Console.WriteLine("Employee Salary:" +salary);


            Console.ReadLine();

        }
    }
}

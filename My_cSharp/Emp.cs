using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{
    internal class Emp
    {
        public static void Main()
        {
           Static();
        }
        public static void Static()
        { 
                Console.WriteLine("Enter the employee details: ");
                Console.WriteLine("Enter the Employee ID: ");
                int empID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee name: ");
                String empName = Console.ReadLine();
                Console.WriteLine("Enter the Employee's salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                Emp emp = new Emp();
                emp.Instance(empID, empName, salary);
        }
        public void Instance(int empID, String empName, int salary)
        {
                Console.WriteLine("Employee ID is: " + empID);
                Console.WriteLine("Employee Name is "+ empName);
                Console.WriteLine("Employee Salary is "+ salary); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace My_cSharp
{
    internal class Paramarr
    {
        public static void Main()
        {
            arrsum();
            parammul(1,2,3,4,5,6,7,8,9,10);
            int studentId;
            String studentName , studentDept;
            details(out studentId, out studentName, out studentDept);
            Console.WriteLine($"Student ID is :  {studentId}");
            Console.WriteLine($"Student name is :  {studentName}");
            Console.WriteLine($"Student dept is : { studentDept}");

        }
         public static void arrsum()
         {
                int sum = 0;
                int[,] array = new int[,]
                {
                    { 23, 34, 45 },
                    { 32, 45, 56 }
                };

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                }
                Console.WriteLine("The sum of 2d array is: " +sum);
         }

        public static void parammul(params int[] numbers)
        {
            Console.WriteLine("Enter which multiplication table you want to display: ");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach(int i in numbers)
            {
                Console.WriteLine("{0} x {1} = {2} ", num, i , (num*i));
                
            }
                
        }
        public static void details(out int studentId, out String studentName, out String studentDept)
        {   
            
            studentId = 100;
            studentName = "John";
            studentDept = "ECE";
        }
        

    }
}

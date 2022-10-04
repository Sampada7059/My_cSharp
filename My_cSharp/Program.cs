
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Csharp
{
    internal class ctrl
    {
        public static void Main()
        {
            Conditional();
            ctrl c = new ctrl();
            c.control();

        }
        public static void Conditional()
        {
            int num;
            Console.WriteLine("Enter any positive number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
        public void control()
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array elements: ");
            int[] arr = new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Elements in the Array");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Max value is "+ arr.Max());
            Console.WriteLine("Min value is " + arr.Min());
            Console.WriteLine("Count value is " + arr.Count());
            Console.WriteLine("Sum value is " + arr.Sum());
            Console.WriteLine("Avg value is " + arr.Average());
        }
        
    }
}

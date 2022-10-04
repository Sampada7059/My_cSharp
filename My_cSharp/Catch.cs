using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{
    internal class Catch
    {
        public static void Main(string[] args)
        {
            float result = 0;
            int num1, num2;
            Console.WriteLine("Enter num1 and num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    result = num1 / num2;
                    if (float.IsInfinity(result))
                    {
                        Console.WriteLine("Division by zero is not allowed");
                    }
                }
                    catch(DivideByZeroException){
                        Console.WriteLine("Cannot divide by zero");
                    }
                finally
                {
                    Console.WriteLine(result);
                }  
            
        }
    }
}

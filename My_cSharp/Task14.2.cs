using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static My_cSharp.Task14;
namespace My_cSharp
{
    internal class Task14
    {
        public class addition
        {
            public addition(int num1, int num2)
            {

                Console.WriteLine("Int Sum = {0}", num1 + num2);
            }
            public addition(float num1, float num2)
            {

                Console.WriteLine("Double Sum = {0}", num1 + num2);
            }
            public addition(string s1, string s2)
            {
                Console.WriteLine(s1 + s2);
            }
        }
        public static void Main()
        {
            addition add = new addition(100, 110);
            addition add1 = new addition(12.14f, 17.9f);
            addition add2 = new addition("Allu", "Arjun");
        }
    }
}

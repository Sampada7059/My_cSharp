using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{
    internal class Enum
    {
        enum basics
        {
            Violin,
            Guitar = 10,
            Drums,
            Flute = 40,
            Piano = -2,
            Harp 
        }
        public enum salary
        {
            A,
            B,
            C
        }
        public static void bonus(int bonus, salary s)
        {
            if ((int)s == 0)
            {
                Console.WriteLine("Bonus : " + 5 * bonus);
            }
            else if ((int)s == 1)
            {
                Console.WriteLine("Bonus : " + 3 * bonus);
            }
            else
            {
                Console.WriteLine("Bonus : " + bonus);

            }
        }
        public static void Main()
        {
            Console.WriteLine((int)basics.Violin);
            Console.WriteLine(basics.Guitar);
            int methods = (int)basics.Flute;
            Console.WriteLine(methods);
            var del = (basics)40;
            Console.WriteLine(del);

            bonus(10000, salary.A);
            bonus(10000, salary.B);
            bonus(10000, salary.C);
        }
    }
}

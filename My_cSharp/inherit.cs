using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{   
    public class Bonus
    {
        protected int bonus;
    }
    public class Staff : Bonus
    {
        protected int salary = 30000;
        public void GetBonus1()
        {
            bonus = 2 * salary;
            Console.WriteLine($"Staff salary: {salary} and Bonus = {bonus}");
        }
    }
    public class nonStaff: Staff
    {
        protected int salary = 16000;
        public void GetBonus2()
        {
            bonus = 3 * salary;
            Console.WriteLine($"nonStaff salary: {salary} and Bonus = {bonus}");

        }
    }
    internal class inherit
    {
        class pgm
        {
            public static void Main()
            {
                Staff s1 = new Staff();
                s1.GetBonus1();
                nonStaff s2 = new nonStaff();
                s2.GetBonus2();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace My_cSharp
{
    internal class validation
    {
        public static void Main()
        {
            number();
        }
        public static void number()
        {
            Console.WriteLine("Hello there! Please enter the mobile number");
            Console.WriteLine("Enter the 10 digit number and starting with 7/8/9");
            var number = Console.ReadLine();
            var validate_number = Regex.IsMatch(number, @"^([7-9]{1})([0-9]{9})$");
            Console.WriteLine(validate_number);

        }
    }
}

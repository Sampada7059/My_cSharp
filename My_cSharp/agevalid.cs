using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{
    internal class agevalid
    {
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(String message): base(message)
            {
            }
            static void validate(int age)
            {
                if(age < 22)
                {
                    throw new InvalidAgeException("Oops! Your age must greater than 22 for eligibility!");
                }
                else
                {
                    Console.WriteLine("Your age is valid for eligibility");
                }
            }
            public static void Main()
            {
                try
                {
                    Console.WriteLine("Please enter your age: ");
                    var age = Convert.ToInt32(Console.ReadLine());
                    validate(age);
                }
                catch(InvalidAgeException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}

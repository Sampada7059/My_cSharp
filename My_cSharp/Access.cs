using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{
     public class program
     {
       internal int num;
     }
     public class access
    {
        public static void Main()
        {
            program a = new program();
            a.num = 100;
            Console.WriteLine(a.num);
           
        }
    }

}

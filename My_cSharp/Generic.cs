using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Generic
    {
        public delegate T AreaDelegate<T>(T r);
        class area
        {
            public double area1(double r)
            {
                return 3.142 * r * r;
            }
            public double area2(double a)
            {
                return a * a;
            }
            public int area2(int a)
            {
                return a * a;
            }
            public double area3(double b)
            {
                return 6 * b * b;
            }
            public int area3(int b)
            {
                return 6 * b * b;
            }
        }
        class calculate
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Areas of :Circle,Square(d)(i),Cube");
                Console.WriteLine("-------------------------------------");
                area c = new area();
                //double
                AreaDelegate<double> dlgt = new AreaDelegate<double>(c.area1);
                Console.WriteLine("Circle = " + dlgt(7));
                Console.WriteLine("-------------------------------------");

                dlgt = c.area2;
                Console.WriteLine("Square(double) = " + dlgt(5));
                Console.WriteLine("-------------------------------------");

                dlgt = c.area3;
                Console.WriteLine("Cube(double) = " + dlgt(4));
                Console.WriteLine("-------------------------------------");
                //int
                AreaDelegate<int> dlgt1 = new AreaDelegate<int>(c.area2);
                Console.WriteLine("Square (int) = " + dlgt1(5));
                Console.WriteLine("-------------------------------------");

                dlgt = c.area3;
                Console.WriteLine("Square(int) = " + dlgt1(9));
                Console.WriteLine("-------------------------------------");
            }
        }

    }
}

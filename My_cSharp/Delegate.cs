using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_cSharp
{
    public class Delegate
    {
        public delegate void InterestDel(string bankname, double P, double T, double R);
        public void GetInterest1(string bankname, double P, double T, double R)
        {
            Console.WriteLine($"Bank Name: {bankname}");
            Console.WriteLine($"Interest rate: {(P * T * R) / 100}" + "\n");
        }
        public void GetInterest2(string bankname, double P, double T, double R)
        {
            Console.WriteLine($"Bank Name: {bankname}");
            Console.WriteLine($"Interest rate: {(P * T * R) / 100}" + "\n");
        }
        public void GetInterest3(string bankname, double P, double T, double R)
        {
            Console.WriteLine($"Bank Name: {bankname}");
            Console.WriteLine($"Interest rate: {(P * T * R) / 100}" + "\n");
        }
        public void GetInterest4(string bankname, double P, double T, double R)
        {
            Console.WriteLine($"Bank Name: {bankname}");
            Console.WriteLine($"Interest rate: {(P * T * R) / 100}" + "\n");
        }
        public void GetInterest5(string bankname, double P, double T, double R)
        {
            Console.WriteLine($"Bank Name: {bankname}");
            Console.WriteLine($"Interest rate: {(P * T * R) / 100}" + "\n");
        }
        public static void Main(string[] args)
        {
            Delegate i = new Delegate();
            InterestDel id = i.GetInterest1;
            id += i.GetInterest2;
            Console.WriteLine("Bank 1:");
            i.GetInterest5("SBI Bank", 20000, 1, 2.70);

            Console.WriteLine("Bank 2:");
            id -= i.GetInterest2;
            i.GetInterest1("HDFC Bank", 5000, 2, 3.50);

            Console.WriteLine("Bank 3:");
            id -= i.GetInterest3;
            i.GetInterest3("Kotak Mahindr Bank", 7000, 3, 3.50);

            Console.WriteLine("Bank 4:");
            id -= i.GetInterest4;
            i.GetInterest4("Axis Bank", 15000, 2, 3.00);

            Console.WriteLine("Bank 5:");
            id -= i.GetInterest5;
            i.GetInterest2("ICICI Bank", 10000, 1, 3.50);


        }


    }
}
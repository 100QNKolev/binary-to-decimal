using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string y = "";

            while (a != 0) 
            {
                int x = a % 2;

                y += x;

                a = (a / 2);
            }

            Console.WriteLine(string.Join("",y.ToCharArray().Reverse()));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static double deQuy(int a, int b)
        {
            if (b == 0)
            {
                return a;
     }

            if (a % b == 0)
            {
                return b;
            }
            return deQuy(b, a % b);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine($"Kết quả: {deQuy(a, b)}");

            Console.ReadKey();
        }
    }
}

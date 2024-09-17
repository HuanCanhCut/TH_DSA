using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static double deQuy(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return (n - 1) + 1.0/n;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kết quả: {deQuy(n)}");

            Console.ReadKey();
        }
    }
}

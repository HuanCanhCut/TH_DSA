using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static int deQuy(int n)
        {
            if (n < 10)
            {
                return 1;
            }
            // Trường hợp đệ quy: chia n cho 10 và đệ quy
            else
            {
                return 1 + deQuy(n / 10);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập n: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Số chữ số của {num} là: {deQuy(num)}");

            Console.ReadKey();
        }
    }
}
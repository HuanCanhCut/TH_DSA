using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSGV
{
    internal class Program
    {
        class GiaoVien
        {
            public string ten;
            public int maGV;
            public int namSinh;
            public string queQuan;

            public void Nhap()
            {
                Console.Write("Nhập tên giáo viên: ");
                ten = Console.ReadLine();

                Console.Write("Nhập mã giáo viên: ");
                maGV = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập năm sinh: ");
                namSinh = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập quê quán: ");
                queQuan = Console.ReadLine();

            }
        }

        class QLGiaoVien
        {
            public int soLuongGV;
            public GiaoVien[] danhSachDV;

            public void Nhap ()
            {
                Console.Write("Nhập số lượng giáo viên: ");
                soLuongGV = Convert.ToInt32(Console.ReadLine());

                danhSachDV = new GiaoVien[soLuongGV];

                for (int i = 0; i < soLuongGV; i++)
                {
                    GiaoVien giaoVien = new GiaoVien();

                    giaoVien.Nhap();

                    danhSachDV[i] = giaoVien;

                }
            }

            public void HienThi()
            {   
                Console.WriteLine("Danh sách giáo viên > 40 tuổi: ");

                for (int i = 0; i < danhSachDV.Length; i++)
                {
                    if (DateTime.Now.Year - danhSachDV[i].namSinh > 40)
                    {
                        Console.WriteLine($"{danhSachDV[i].maGV}\t{danhSachDV[i].ten}\t{danhSachDV[i].namSinh}\t{danhSachDV[i].queQuan}");
                    }
                }

                Console.WriteLine("Danh sách giáo viên < 25 tuổi: ");

                for (int i = 0; i < danhSachDV.Length; i++)
                {
                    if (DateTime.Now.Year - danhSachDV[i].namSinh < 25)
                    {
                        Console.WriteLine($"{danhSachDV[i].maGV}\t{danhSachDV[i].ten}\t{danhSachDV[i].namSinh}\t{danhSachDV[i].queQuan}");
                    }
                }

            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            QLGiaoVien QL = new QLGiaoVien();

            QL.Nhap();

            QL.HienThi();

            Console.ReadKey();
        }
    }
}

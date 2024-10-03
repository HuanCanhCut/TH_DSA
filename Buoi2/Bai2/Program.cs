using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{

    class NhanVien
    {
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string phongBan { get; set; }
        public int luongCoBan { get; set; }
        public int thuong { get; set; }
        public int thucLinh { get; set; }

        public NhanVien(string maNV, string hoTen, int namSinh, string phongBan, int luongCoBan, int thuong, int thucLinh)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.phongBan = phongBan;
            this.luongCoBan = luongCoBan;
            this.thuong = thuong;
            this.thucLinh = thucLinh;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng nhân viên: ");
            int length = int.Parse(Console.ReadLine());

            NhanVien[] danhSachNV = new NhanVien[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}: " );

                Console.Write("Mã nhân viên: ");
                string maNV = Console.ReadLine();

                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();

                Console.Write("Năm sinh: ");
                int namSinh = int.Parse(Console.ReadLine());

                Console.Write("Phong ban: ");
                string phongBan = Console.ReadLine();

                Console.Write("Lương cơ bản: ");
                int luongCoBan = int.Parse(Console.ReadLine());

                Console.Write("Thưởng: ");
                int thuong = int.Parse(Console.ReadLine());

                int thucLinh = luongCoBan + thuong;
                
                danhSachNV[i] = new NhanVien(maNV, hoTen, namSinh, phongBan, luongCoBan, thuong, thucLinh);
            }

            //a.Tính tổng thực lĩnh tháng của tất cả nhân viên trong công ty.
            int tongThucLinh = 0;
            int minIndex = 0;
            int count = 0;
            int target = 1200000;

            for (int i = 0; i < danhSachNV.Length; i++)
            {
                tongThucLinh += danhSachNV[i].thucLinh;

                //In danh sách những nhân viên có mức lương cơ bản thấp nhất.
                if (danhSachNV[i].thucLinh < danhSachNV[minIndex].thucLinh)
                {
                    minIndex = i;
                }

                //. Đếm số lượng nhân viên có mức thưởng >= 1200000. 
                if (danhSachNV[i].thuong >= target)
                {
                    count++;
                }

                //Cập nhật tăng lương của tất cả các nhân viên lên 5%
                danhSachNV[i].luongCoBan += Convert.ToInt32(danhSachNV[i].luongCoBan * 0.05);

            }

            Console.WriteLine($"Tổng thực lĩnh là: {tongThucLinh}");
  
            Console.WriteLine($"Nhân viên có mức lương cơ bản thấp nhất là: {danhSachNV[minIndex].hoTen}");

            Console.WriteLine($"Số nhân viên có mức thưởng >= {target} là: {count}");

            Console.ReadKey();
        }
    }
}

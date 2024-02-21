using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeMinhKhoi_01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int luachon = 0;
            do
            {
                Console.WriteLine("Chuong trinh quan li nhan vien");
                Console.WriteLine("==============================");
                Console.WriteLine("Hay nhap lua chon:");
                Console.WriteLine("1.Nhap danh sach nhan vien");
                Console.WriteLine("2.Xuat thong tin nhan vien");
                Console.WriteLine("3.Thong ke tong luong phai tra cho nhan vien");
                Console.WriteLine("4.Thong ke luong thuc lanh va trung binh cua nhan vien");
                Console.WriteLine("0.Thoat chuong trinh");
                Console.WriteLine("==============================");
                Console.Write("Hay nhap lua chon:");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong phai tra cho nhan vien la: {ql.tinhTongLuong()}");
                        break;
                    case 4:
                        Console.WriteLine($"Tong luong trung binh phai tra la:{ql.TinhLuongTrungBinh()}");
                        break;
                }
            } while (luachon != 0);
        }
    }
}

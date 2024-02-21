using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeMinhKhoi_01
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.WriteLine("Hay chon loai nhan vien(1: Bien Che | 2: Hop Dong)");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban da chon sai chuc nang, vui long nhap lai:");
                        break;
                }
                Console.Write("Ban co muon nhap nua khong? (Y / N)");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20}  {"Thuc lanh",20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10} {x.Hoten, 20} {x.TinhLuong(),20}");
            }
        }
        public double tinhTongLuong()
        {
            double sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }
            return sum;
        }
        public double TinhLuongTrungBinh()
        {
            double avg = 0;
            foreach (NhanVien nv in dsNV)
            {
                avg += nv.TinhLuong();
            }
            return avg;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeMinhKhoi_01
{
    class NhanVienBC:NhanVien
    {
        private string mucxeploai;

        public NhanVienBC():base()
        {

        }
        public NhanVienBC(string maso, string hoten, int luongcung) : base(maso,hoten,luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string MucXL
        {
            set { this.mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap xep loai:");
            this.mucxeploai = Console.ReadLine();
        }
        public override double TinhLuong()
        {
            double luong;
            if (this.mucxeploai == "a" )
            {
                luong  = Luongcung + 1.8 * Luongcung;
            }
            else if (this.mucxeploai == "b")
            {
                luong = Luongcung + 1.2 * Luongcung;
            }
            else
            {
                luong  = Luongcung + 0.8 * Luongcung;
            }
            return luong;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPaYSanHy_01_2321160055
{

    class NhanVien
    {
        public string maso { get; set; }
        public string hoten { get; set; }
        public int luongcung { get; set; }
        public virtual void Nhap()
        {
            Console.Write(" -Nhap ma so:");
            maso = Console.ReadLine();
            Console.Write(" -Nhap ho ten:");
            hoten = Console.ReadLine();
            Console.Write(" -Nhap luong cung:");
            luongcung = int.Parse(Console.ReadLine());
        }  
        public virtual int TinhLuong()
        {
            return luongcung;
        }
    }

    class NhanVienBienChe : NhanVien
    {
        public string mucxeploai { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write(" -Nhap muc xep loai (A, B, C): ");
            mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            int thuong = 0;
            switch (mucxeploai)
            {
                case "A": thuong = (int)(1.8 * luongcung);
                    break;
                case "B":
                    thuong = (int)(1.2 * luongcung);
                    break;
                case "C":
                    thuong = (int)(0.8 * luongcung);
                    break;
            }
            return luongcung + thuong;
        }
    }

    class NhanVienHopDong : NhanVien
    {
        public int doanhthu { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write(" -Nhap doanh thu:");
            doanhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            return luongcung + (int)(0.05 * doanhthu);
        }
    }

    class QuanLyNhanVien
    {
        public List<NhanVien> dsNV { get; set; }
        public QuanLyNhanVien()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            Console.Write(" -Nhap so luong nhan vien:");
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($" -Nhap thong tin nhan vien thu {i + 1}:");
                Console.Write(" -Chon loai nhan vien (1 - Bien che, 2 - Hop dong): ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: NhanVienBienChe nvbc = new NhanVienBienChe();
                        nvbc.Nhap();
                        dsNV.Add(nvbc);
                        break;
                    case 2:NhanVienHopDong nvhd = new NhanVienHopDong();                      
                        nvhd.Nhap();
                        dsNV.Add(nvhd);
                        break;
                    default:
                        Console.WriteLine(" -Lua chon khong hop le:");
                        break;
                }
            }while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
        public void XuatDS()
        {
            foreach (var nv in dsNV)
            {
                Console.WriteLine($" -Ma so: {nv.maso},  -Ho ten: {nv.hoten},  -Luong thuc lanh: {nv.TinhLuong()}");
            }
        }
        public int TinhTongLuong()
        {
            int tongluong = 0;
            foreach(var nv in dsNV)
            {
                tongluong += nv.TinhLuong();
            }
            return tongluong;
        }
        public double TinhLuongTrungBinh()
        {
            if (dsNV.Count == 0)
                return 0;
            double tongluong = TinhTongLuong();
            return tongluong / dsNV.Count;
        }
    }  
}

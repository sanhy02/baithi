using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPaYSanHy_01_2321160055
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            int choice;
            do
            {
                Console.WriteLine("====== MENU ======");
                Console.WriteLine("1.Nhap danh sach nhan vien");
                Console.WriteLine("2.Hien thi thong tin cac nhan vien");
                Console.WriteLine("3.Thong ke tong tien luong cong ty");
                Console.WriteLine("4.Tinh tien luong trung binh cua cac nhan vien");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        qlnv.NhapDS();
                        break;
                    case 2:
                        qlnv.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($" -Tong tien luong cong ty phai tra: {qlnv.TinhLuongTrungBinh()}");
                        break;
                    case 4:
                        Console.WriteLine($" -Tien luong trung binh cua cac nhan vien: {qlnv.TinhLuongTrungBinh()}");
                        break;
                    case 0:
                        Console.WriteLine(" -Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine(" -Lua chon khong hop le");
                        break;
                }
            } while (choice != 0);
        }
    }
}

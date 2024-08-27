//0.0.2 quan ly danh sach HOCSINH
using System;

namespace QuanLyHS 
{
    class HocSinh 
    {
        public string Ten {set; get;}
        public int Tuoi {set; get;}
        public string Lop {set; get;}
        public HocSinh (string ten, int tuoi, string lop)
        {
            Ten = ten;
            Tuoi = tuoi;
            Lop = lop; 
        }

        public void HienThi()
        {
            Console.WriteLine($"{Ten} - {Tuoi} - {Lop}"); 
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            List<HocSinh> dsHocSinh = new List<HocSinh>(); 
            int luachon; 
            do {
                Console.WriteLine("Quan ly danh sach hoc sinh"); 
                Console.WriteLine("1. Them hoc sinh");
                Console.WriteLine("2. Hien thi danh sach"); 
                Console.WriteLine("3. Tim kiem hoc sinh"); 
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Nhap lua chon: "); 
                luachon = int.Parse(Console.ReadLine()); 

                switch (luachon)
                {
                    case 1:
                        ThemHS(dsHocSinh);
                        break; 
                    case 2:
                        HienThiDanhSach(dsHocSinh);
                        break; 
                    case 3: 
                        TimKiem(dsHocSinh);
                        break; 
                    case 0: 
                        Console.WriteLine("Ket thuc");
                        break; 
                    default: 
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!"); 
                        break; 
                }

                Console.WriteLine(); 
            } while (luachon != 0); 
        }

        static void ThemHS(List<HocSinh>dsHocSinh)
        {
            Console.Write("Nhap ten hoc sinh: ");
            string ten = Console.ReadLine(); 
            Console.Write("Tuoi: ");
            int tuoi = int.Parse(Console.ReadLine()); 
            Console.Write("Lop: ");
            string lop = Console.ReadLine(); 

            HocSinh hs1 = new HocSinh(ten, tuoi, lop); 
            dsHocSinh.Add(hs1); 
            
            Console.WriteLine("Da them hoc sinh thanh cong"); 
        }

        static void HienThiDanhSach(List<HocSinh>dsHocSinh)
        {
            Console.WriteLine("Danh sach hoc sinh:"); 
            foreach(HocSinh hs1 in dsHocSinh)
            {
                hs1.HienThi(); 
            }
        }

        static void TimKiem(List<HocSinh>dsHocSinh) 
        {
            Console.Write("Nhap ten hc sinh can tim: "); 
            string ten = Console.ReadLine(); 

            bool tim_kiem = false; 

            foreach(HocSinh hs1 in dsHocSinh)
            {
                if(hs1.Ten.ToLower().Contains(ten.ToLower()))
                {
                    hs1.HienThi();
                    tim_kiem = true; 
                }
            }
            if (!tim_kiem)
            {
                Console.WriteLine("Khong tim thay hoc sinh nay."); 
            }
        }
    }
}
using System;
using System.Dynamic;

namespace CS_Event
{
    public delegate void Sukiennhapso (int x); 
    class UserInput 
    {
        public event Sukiennhapso nhapso; //bien nhapso chi co the thuc hien phep toan += hoac -=,
        //khong duoc thuc hien phep toan gan 
        public void Input ()
        {
            do 
            {
                Console.Write("Nhap vao so nguyen:"); 
                string s = Console.ReadLine();
                int i = Int32.Parse(s); //chuoi nhap vao duoc chuyen thanh so nguyen 
                // phat sk 
                nhapso?.Invoke(i); 
            } while (true); 
        }
    }

    class Tinhcan
    {
        public void Sub(UserInput input) //dki su kien nhap so cua userinput 
        {
            input.nhapso += Can; 
        }
        public void Can(int i) 
        {
            Console.WriteLine($"Can bac hai cua so {i} la: {Math.Sqrt(i)}"); 
        }
    }

    class BinhPhuong 
    {
        public void Sub(UserInput input) //dki su kien nhap so cua userinput 
        {
            input.nhapso += TinhBinhPhuong; 
        }
        public void TinhBinhPhuong(int i) 
        {
            Console.WriteLine($"Binh phuong cua {i} la: {i*i}"); 
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            //publisher 
            UserInput userInput = new UserInput(); 
            userInput.nhapso += x => {
                Console.WriteLine("Ban vua nhap so:" + x); 
            };
            //subcriber
            Tinhcan tinhcan = new Tinhcan(); 
            tinhcan.Sub(userInput); 
            

            BinhPhuong bphuong = new BinhPhuong(); 
            bphuong.Sub(userInput);
            userInput.Input(); 
        }
    }
}

/*
1. Lap trinh huong su kien, publisher va subscriber 
- Lap trinh huong su kien la 1 ky thuat lap trinh: cta xd nhung cai lop co the 
phat di nhung su kien (no thong bao cho biet co 1 sk nao do xay ra) -> publisher 
- nhung lop dang ki: khi sk do xay ra thi se nhan duoc nhung thong tin -> subscriber 
- mo hinh nay su dung delegate de trien khai 

vd trien khai mo hinh lap trinh huong sk, xd 1 lop de nguoi dung nhap vao 1 con so. khi user nhap vao 1 con so thi no se phat di sk user vua nhap 1 con so 
- goi nhung phuong thuc luu trong delegate tuong tu nhu hanh dong phat di sk 

2. Khai bao tao sk voi tu khoa event 
- damr bao tinh lap trinh huong sk trong C# 
vd 
                Tinhcan tinhcan = new Tinhcan(); 
                tinhcan.Sub(userInput); 
                userInput.Input(); 

            BinhPhuong bphuong = new BinhPhuong(); 
            bphuong.Sub(userInput);
            userInput.Input(); 

thi no chi chay cai binh phuong thoi chu tinh can khong chay 
=> public event Sukiennhapso nhapso; 
+= dki nhan su kien 
-= xac nhan huy bo sk 
- sk phat di se co 2 lop nhan duoc thong tin 
- bien khai bao voi event (public event Sukiennhapso nhapso;) no la 1 delegate 
maf 1 bthuc lambda co the gan cho 1 bieu thuc delegate 

3. DeLegate dang ki nhan su kien 


*/

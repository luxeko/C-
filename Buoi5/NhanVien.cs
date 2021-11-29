using System;
namespace Buoi5
{
    /*
    class abstract: ko tạo dc đối tượng từ kiểu class này
    chứa các hàm normal + các hàm abstract
    */
    abstract class NhanVien : Nguoi
    {
        private string manv;
    
        protected NhanVien(string name, int age, string address, string manv) : base(name, age, address)
        {
            this.manv = manv;
        }

        protected NhanVien()
        {
        }

        public string Manv { get => manv; set => manv = value; }

        public override void doWork()
        {
            System.Console.WriteLine("Nhan vien");
        }

        public override void input()
        {
            base.input();
            System.Console.WriteLine("Nhap ma nv: ");
            this.manv = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + "; ma nv: " + manv + "; luong: " + tinhLuong() ;
        }

        public abstract float tinhLuong();
    }
}
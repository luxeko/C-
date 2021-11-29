using System;

namespace Buoi5
{
    public class SinhVien : Nguoi
    {
        // định nghĩa đặc điểm riêng, hành vi riêng của lớp con
        private string masv;
        private string maLop;

        public SinhVien():base()
        {
        }

        public SinhVien(string name, int age, string address, string masv, string maLop) : base(name, age, address)
        {
            this.masv = masv;
            this.maLop = maLop;
        }

        public string Masv { get => masv; set => masv = value; }
        public string MaLop { get => maLop; set => maLop = value; }

        public override sealed void doWork()
        {
            System.Console.WriteLine("Sinh vien phai di hoc dung gio");
        }

        public override void input()
        {
            base.input();
            System.Console.WriteLine("Ma sv: ");
            this.masv = Console.ReadLine();
            System.Console.WriteLine("Mã lớp: ");
            this.maLop = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + "; masv: " + masv + "; malop: " + maLop;
        }
    }
    class SinhVienFullStack : SinhVien
    {
        // public override void doWork()
        // {
            
        // } cannot override inherited member 'SinhVien.doWork()' because it is sealed (hàm sealed ko cho phép lớp con kế thừa)

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void input()
        {
            base.input();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


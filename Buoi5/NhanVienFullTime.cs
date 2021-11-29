using System;
namespace Buoi5
{
    class NhanVienFullTime : NhanVien
    {
        private float hsLuongBh;
        private float hsLuongCb;
        const int LUONGCB = 3000;
        const int LUONGBH = 1000;

        public NhanVienFullTime()
        {
        }

        public NhanVienFullTime(string name, int age, string address, string manv, float hsLuongBh, float hsLuongCb) : base(name, age, address, manv)
        {
            this.hsLuongBh = hsLuongBh;
            this.hsLuongCb = hsLuongCb;
        }

        public override float tinhLuong()
        {
            return hsLuongBh * LUONGBH + hsLuongCb * LUONGCB;
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap hs luong bh: ");
            this.hsLuongBh = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap hs luong cb: ");
            this.hsLuongCb = Convert.ToSingle(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
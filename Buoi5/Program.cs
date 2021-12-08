using System.Collections.Generic;
using System;

namespace Buoi5
{
    class Animal
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--------- Chương trình quản lý nhân sự ---------");
            Nguoi ng1 = new Nguoi();
            ng1.doWork();

            SinhVien sv1 = new SinhVien();
            sv1.doWork();
            Nguoi ng2 = new SinhVien();
            ng2.doWork();
            
            System.Console.WriteLine("ng1 co phai la nguoi khong?" + (ng1 is Nguoi));
            System.Console.WriteLine("ng1 co phai la SinhVien khong?" + (ng1 is SinhVien));
            System.Console.WriteLine("ng2 co phai la nguoi khong?" + (ng2 is Nguoi));
            System.Console.WriteLine("ng2 co phai la SinhVien khong?" + (ng2 is SinhVien));

            if(ng1 is SinhVien)
            {
                SinhVien sv2 = (SinhVien)ng1;
            }
            SinhVien sv3 = (SinhVien)ng2;

            NhanVien nv1 = new NhanVienFullTime();
            nv1.input();
            System.Console.WriteLine(nv1.ToString());

            List<Nguoi> dsNhanSu = new List<Nguoi>();
            dsNhanSu.Add(nv1);
            dsNhanSu.Add(sv3);
            dsNhanSu.Add(ng2);
            System.Console.WriteLine("Ds list: " + dsNhanSu.Count);
            // check tồn tại
            System.Console.WriteLine("Nhav vien ton tai:" + dsNhanSu.Contains(nv1)); 
            // xoá 1 phần từ khỏi ds
            System.Console.WriteLine("Xoá nv thành công: " + (dsNhanSu.Remove(nv1)?"Thanh cong":"Khong tim thay phan tu nay"));
            // cập nhật
            dsNhanSu[0] = new NhanVienFullTime();
            // duyệt: index

            System.Console.WriteLine("duyệt theo index: ");
            for(int i = 0; i < dsNhanSu.Count; i++)
            {
                System.Console.WriteLine(dsNhanSu[i]);
            }

            System.Console.WriteLine("duyệt theo foreach: ");
            // varm dynamic. object
            foreach (var item in dsNhanSu)
            {
                System.Console.WriteLine(item);
            }
            Console.Read();            
        }
    }
}

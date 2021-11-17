using System;
using System.Globalization;
/*
    Xây dựng 1 chương trình đơn giản để cảnh báo số ngày sinh nhật sắp tới của 1 nhân viên trong công ty.
    Người dùng nhập tên nhân viên, ngày sinh ( nhập ngày, nhập tháng, nhập năm ).
    Hệ thống trả về “Con “ + số ngày + “ thi toi sinh nhat cua nhan vien ”+ ten nhan vien + “: “ + ngay sinh nhat sap toi cua nhan vien.
    Hoặc ngày sinh == ngày hiện tại, thì in ra “Chuc mung sinh nhat nhan vien ”+ ten nhan vien.

    Sau khi trả về kết quả, hỏi ng dùng tiếp tục muốn thực hiện tiếp hay không? ( y: tiếp tục ).
*/
namespace bai3
{    class Bai3

    {        
        static void Main(string[] args)
        {
            String name;
            DateTime mBirthday;
            DateTime now = DateTime.Now;
            Console.WriteLine("Nhap ten nhan vien: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh (dd/MM/yyyy): ");
            mBirthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DateTime birthDayInY = new DateTime(now.Year, mBirthday.Month, mBirthday.Day);

            TimeSpan diff = birthDayInY.Subtract(now);
            if(diff.Days < 0){
                birthDayInY = new DateTime(now.Year + 1, mBirthday.Month, mBirthday.Day);
                diff = birthDayInY.Subtract(now);

                System.Console.WriteLine("{0}",diff.Days);
            }else if(diff.Days == 0){
                System.Console.WriteLine("HBPD");
            }else{
                diff = birthDayInY.Subtract(now);
                System.Console.WriteLine("{0}",diff.Days);
            }
        }

    }
}

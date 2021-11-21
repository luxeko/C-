using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bookHouse bh = new bookHouse();
            bh.addBook();
            bh.showAllBook();
        }
        static void showMenu()
        {
            System.Console.WriteLine("--- Quản lý thư viện ---");
            System.Console.WriteLine("1. Thêm 1 quyển sách theo vị trí kệ");
            System.Console.WriteLine("2. Cập nhập 1 quyển sách theo mã sách");
            System.Console.WriteLine("3. Hiển thị thông tin các sách khi người dùng nhập vị trí kệ");
            System.Console.WriteLine("4. Hiển thị tổng số sách và vị trị kệ sách");
            System.Console.WriteLine("5. In danh sách sách trong nhà sách");
            System.Console.WriteLine("6. Thoát!");
            System.Console.WriteLine("Chọn: ");
        }
    }
}

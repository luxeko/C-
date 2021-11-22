using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bookHouse bh = new bookHouse();
            int choose;
            Boolean flag = true;
            do
            {
                showMenu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        bh.addBook();
                        break;
                    case 2:
                        bh.updateBook();
                        break;
                    case 3:
                        bh.showBookFromLocation();
                        break;
                    case 4:
                        bh.showBookShelfAndTotalBooks();
                        break;
                    case 5:
                        bh.showAllBook();
                        break;
                    case 6:
                        System.Console.WriteLine("Thoát!");
                        break;
                    default:
                        System.Console.WriteLine("Nhập sai! vui lòng chọn lại");
                        break;
                }
                if(choose == 6) flag = false;
            } while (flag == true);
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

using System;

namespace Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BookHouse nhaSach = new BookHouse();
            int choose;
            Boolean flag = true;
            do
            {
                showMenu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Case1(ref nhaSach);
                        break;
                    case 2:
                        Case2(ref nhaSach);
                        break;
                    case 3:
                        Case3(ref nhaSach);
                        break;
                    case 4:
                        Case4(ref nhaSach);
                        break;
                    case 5:
                        System.Console.WriteLine("Thoát!");
                        break;
                    default:
                        System.Console.WriteLine("Nhập sai! vui lòng chọn lại");
                        break;
                }
                if(choose == 5) flag = false;
            } while (flag == true);
        }
        static void showMenu()
        {
            System.Console.WriteLine("--- Quản lý thư viện ---");
            System.Console.WriteLine("1. Thêm 1 quyển sách theo vị trí kệ");
            System.Console.WriteLine("2. Cập nhập 1 quyển sách theo mã sách");
            System.Console.WriteLine("3. Hiển thị thông tin các sách khi người dùng nhập vị trí kệ");
            System.Console.WriteLine("4. In danh sách sách trong nhà sách");
            System.Console.WriteLine("5. Thoát!");
            System.Console.WriteLine("Chọn: ");
        }
        static void Case1( ref BookHouse nhaSach)
        {
            String confirm = "";
            do
            {
                int vitriKe = 0;
                Sach book;
                while (true)
                {
                    Console.WriteLine("Nhập kệ sách (0 -> 19): ");
                    vitriKe = Convert.ToInt32(Console.ReadLine());
                    if(vitriKe < 0 || vitriKe >= nhaSach.ListBook.GetLength(0))
                    {
                        System.Console.WriteLine("Vị trí kệ không đúng");
                    }
                    else
                    {
                        break;
                    }
                }
                System.Console.WriteLine("Nhập 1 quyển sách");
                book = new Sach();
                book.input(ref nhaSach);
                int ketQuaThem = nhaSach.addBook(book, vitriKe);
                if(ketQuaThem == 1)
                {
                    System.Console.WriteLine("Thêm sách thành công");
                }
                else
                {
                    Console.WriteLine(ketQuaThem == 0?"Kệ sách đầy":"Giá trị nhập vào không đúng");
                    while (true)
                    {
                        vitriKe = Convert.ToInt32(Console.ReadLine());
                        ketQuaThem = nhaSach.addBook(book, vitriKe);
                        if(ketQuaThem == 1)
                        {
                            System.Console.WriteLine("Thêm sách thành công");
                            break;
                        }
                    }
                }
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        //update book
        static void Case2(ref BookHouse nhaSach)
        {
            String confirm = "";
            Sach book;
            int keSach = 0;
            int viTri = 0;
            do
            {
                while (true)
                {
                    // hỏi người dùng lựa chọn kệ sạch 0 - 49
                    // thêm các quyển sách vào trong listBook theo kệ sách 
                    System.Console.WriteLine("Nhập kệ sách (0 -> 19): ");
                    keSach = Convert.ToInt32(Console.ReadLine());
                    if(keSach >= 0 && keSach < 20)
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Kệ sách không hợp lệ!");
                    }
                }
                while (true)
                {
                    System.Console.WriteLine("Nhập vị tri sách (bắt đầu từ 0): ");
                    viTri = Convert.ToInt32(Console.ReadLine());
                    if(nhaSach.ListBook[keSach][viTri] == null)
                    {
                        System.Console.WriteLine("Vị trí chưa có sách");
                        break;
                    }
                    else{
                        while (true)
                        {
                            System.Console.WriteLine("Nhập id sách để update: ");
                            string id = Console.ReadLine();
                            bool checkID = nhaSach.checkID(id);
                            if(checkID == true)
                            {
                                System.Console.WriteLine("Nhập 1 quyển sách");
                                book = nhaSach.ListBook[keSach][viTri];
                                book.input(ref nhaSach);                                
                                break;
                            }
                            else{
                                System.Console.WriteLine("Id không tồn tại");
                            }
                        }
                    }
                }
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        //show 1 bookshelf
        static void Case3(ref BookHouse nhaSach)
        {
            String confirm = "";
            do
            {
                int count = 0;
                System.Console.WriteLine("Nhập kệ sách (0 -> 19): ");
                int keSach = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (keSach >= 0 && keSach < 19) break;
                    else System.Console.WriteLine("Nhập sai vị trí kệ (0 -> 19)");
                }
                for(int i = 0; i < nhaSach.ListBook.GetLength(0); i++)
                {
                    if(nhaSach.ListBook[keSach] == nhaSach.ListBook[i])
                    {
                        System.Console.WriteLine("- Kệ sách {0} hiện có {1} quyển sách: ", i, nhaSach.ListViTri[i]);
                        for(int j = 0; j < nhaSach.ListViTri[i]; j++)
                        {   
                            if(nhaSach.ListBook[keSach][j] != null)
                            {
                                count++;
                                Sach book = nhaSach.ListBook[i][j];
                                String ttBook;
                                book.output(out ttBook);
                            }
                        }
                    }
                }
                if(count == 0) System.Console.WriteLine("- Kệ sách chưa có sách");
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        //show all
        static void Case4(ref BookHouse nhaSach)
        {
            nhaSach.showAll();
        }
    }
}

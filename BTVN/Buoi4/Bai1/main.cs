using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Boolean flag = true;
            ClassDao cd = new ClassDao();
            int choose;
            do
            {
                showMenu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        
                        cd.addClass();
                        cd.showList();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        System.Console.WriteLine("Thoát!");
                        break;
                    default:
                        System.Console.WriteLine("Chọn sai! Vui lòng chọn lại");
                        break;
                }
                
                if(choose == 8) flag = false;
            } while (flag == true);
        }
        static void showMenu()
        {
            System.Console.WriteLine("--- Quan ly lop hoc ---");
            System.Console.WriteLine("1. Thêm lớp học mới");
            System.Console.WriteLine("2. Hiển thị danh sách học sinh");
            System.Console.WriteLine("3. Tìm lớp học theo ID");
            System.Console.WriteLine("4. Sắp xếp ds lớp học giảm dần theo tên");
            System.Console.WriteLine("5. Tính số lượng lớp học và số lượng học sinh");
            System.Console.WriteLine("6. Tìm số lớp học có số lượng học sinh nhỏ nhất và lớn nhất");
            System.Console.WriteLine("7. Sắo xếp lớp học tăng dần theo số lượng học sinh");
            System.Console.WriteLine("8. Thoát");
            System.Console.WriteLine("Chọn: ");
        }
    }
}

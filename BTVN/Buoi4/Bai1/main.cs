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
                        break;
                    case 2:
                        cd.showAllList();
                        break;
                    case 3:
                        String confirm ="";
                        do
                        {
                            System.Console.WriteLine("Nhập mã lớp: ");
                            String idFind = Console.ReadLine();
                            lopHoc idCLass = cd.searchClassByID(idFind);
                            if(idCLass != null)
                            {
                                System.Console.WriteLine(idCLass.output());
                            } 
                            else
                            {
                                System.Console.WriteLine("Không tìm thấy lớp có ID: {0}", idFind);
                            }
                            System.Console.WriteLine("Bạn có muốn tiếp tục ko? (bấm n: thoát!)");
                            confirm = Console.ReadLine();
                        } while (!confirm.Equals("n"));
                        
                        break;
                    case 4:
                        cd.sortListById();
                        System.Console.WriteLine("Thành công");
                        System.Console.WriteLine("Danh sách lớp học sau khi sắp xếp");
                        cd.showAllList();
                        break;
                    case 5:
                        cd.sumStudentsAndClasses();
                        break;
                    case 6:
                        cd.minMax();
                        break;
                    case 7:
                        cd.sortHocVien();
                        cd.showAllList();
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
            System.Console.WriteLine("7. Sắp xếp lớp học tăng dần theo số lượng học sinh");
            System.Console.WriteLine("8. Thoát");
            System.Console.WriteLine("Chọn: ");
        }
    }
}

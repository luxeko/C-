using System;
using System.Text;

namespace Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ten, diet toan, diem van, diem anh -> hoc luc
            // tiep tuc
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            String confirm = "", tenHs;
            float diemToan, diemVan, diemAnh;
            // Xu ly menu
            do
            {
                //menu
                showMenu();
                //xu ly nghiep vu
                System.Console.WriteLine("Nhập thông tin học sinh");
                System.Console.WriteLine("Tên học sinh: ");
                tenHs = Console.ReadLine();
                diemToan = -1;
                while(diemToan < 0 || diemToan > 10)
                {
                    System.Console.WriteLine("Điểm toán: ");
                    diemToan = (float)Convert.ToDouble(Console.ReadLine());
                }

                // lap vo han -> thoat lap
                for(; ; ){
                    System.Console.WriteLine("Điểm văn: ");
                    diemVan = (float)Convert.ToDouble(Console.ReadLine());
                    //dk thoát lặp
                    if(diemVan >=0 || diemVan <= 10){
                        break;
                    }
                }       

                // tao label
                nhapdiemanh:
                System.Console.WriteLine("Điểm anh: ");
                diemAnh = (float)Convert.ToDouble(Console.ReadLine());
                if(diemAnh < 0 || diemAnh > 10){
                    goto nhapdiemanh;
                }

                float diemTb = (diemToan + diemVan + diemAnh) / 3;
                if(diemTb >=9){
                    System.Console.WriteLine("Học sinh {0}, điểm TB: {1} học lực {2}", tenHs, diemTb, "Giỏi");
                } else if(diemTb >= 7.5){
                    System.Console.WriteLine("Học sinh {0}, điểm TB: {1} học lực {2}", tenHs, diemTb, "Khá");
                } else if(diemTb >= 4){
                    System.Console.WriteLine("Học sinh {0}, điểm TB: {1} học lực {2}", tenHs, diemTb, "Trung bình");
                } else{
                    System.Console.WriteLine("Học sinh {0}, điểm TB: {1} học lực {2}", tenHs, diemTb, "Yếu");
                }
                //tiep tuc
                System.Console.WriteLine("Bạn có muốn tiếp tục không? (y: tiếp tục)");
                confirm = Console.ReadLine();
            } while ("y".Equals(confirm));
            



        }
        public static void showMenu(){
            Console.WriteLine("--- Xét học lực ---");
            System.Console.WriteLine(">= 9: Gioi");
            System.Console.WriteLine("< 9 và >= 7.5: Khá");
            System.Console.WriteLine("< 7.5 và >= 4: Trung bình");
            System.Console.WriteLine("< 4: Yếu");
        }
    }
}

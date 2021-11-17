using System;

namespace Bai3
{
    class VeHinh
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choose;
            Boolean flag = true;
            do
            {
                showMenu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: 
                        while (true)
                        {
                            System.Console.WriteLine("Nhập độ dài đoạn thẳng: ");
                            int s = Convert.ToInt32(Console.ReadLine());
                            if(s > 0){
                                for(int i = 1; i <= s; i++){
                                    System.Console.Write("* ");
                                }
                                System.Console.WriteLine();
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("Độ dài không hợp lệ");
                            }
                        }
                        break;
                    case 2: 
                        while (true)
                        {
                            System.Console.WriteLine("Nhập chiều dài HCN: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            if(a > 0){
                                while (true)
                                {
                                    System.Console.WriteLine("Nhập chiều rộng HCN: ");
                                    int b = Convert.ToInt32(Console.ReadLine());
                                    if(b > 0){
                                        if (a > b){
                                            System.Console.WriteLine("=> Hình chữ nhật: ");
                                            for(int h = 1; h <= b; h++){
                                                for(int m = 1; m <= a; m++){
                                                    System.Console.Write("* ");
                                                }
                                                System.Console.WriteLine();
                                            }break;
                                        }else{
                                            System.Console.WriteLine("Chiều dài > chiều rộng");
                                        }
                                    }else{
                                        System.Console.WriteLine("Chiều rộng không đúng!");
                                    }
                                }break;
                            }else{
                                System.Console.WriteLine("Chiều dài không đúng!");
                            }
                        }
                        break;
                    case 3: 
                        while (true)
                        {
                            System.Console.WriteLine("Nhập chiều cao tam giác cân: ");
                            int h = Convert.ToInt32(Console.ReadLine());
                            if(h > 0){
                                System.Console.WriteLine("=> Tam giác cân");
                                for(int i = 1; i <= h; i++){
                                    for(int j = 1; j <= h-i; j++){
                                        Console.Write("  ");
                                    }
                                    for(int k = 1; k <= 2*i-1; k++){
                                        Console.Write("* ");
                                    }
                                    System.Console.WriteLine();
                                }
                                break;
                            }else{
                                System.Console.WriteLine("Chiều cao không hợp lệ!");
                            }
                        }
                        break;
                    case 4: 
                        while (true)
                        {
                            System.Console.WriteLine("Nhập chiều cao của tam giác vuông ngược: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            if(n > 0){
                                System.Console.WriteLine("=> Tam giác vuông ngược");
                                for(int i = n; i >= 1; i--){
                                    for(int j = 1; j <= i; j++){
                                        Console.Write("* ");
                                    }
                                    System.Console.WriteLine();
                                }
                                break;
                            }else{
                                System.Console.WriteLine("Số không hợp lệ!");
                            }
                        }
                        break;
                    case 5: 
                        
                        break;
                    case 6: 
                        while (true)
                        {
                            System.Console.WriteLine("Nhập số hàng hình thoi: ");
                            int h = Convert.ToInt32(Console.ReadLine());
                            int m = h/2;
                            int n = h/2;
                            if(h > 0){
                                System.Console.WriteLine("=> Hình thoi: ");
                                for(int i = 1; i <= m; i++){
                                    for(int j = 1; j <= m-i; j++){
                                        Console.Write("  ");
                                    }
                                    for(int k = 1; k <= 2*i-1; k++){
                                        Console.Write("* ");
                                    }
                                    System.Console.WriteLine();
                                }
                                for(int i = n; i >= 1; i--){
                                    for(int j = n; j > i; j--){
                                        Console.Write("  ");
                                    }
                                    for(int k = 1; k <= 2*i-1; k++){
                                        Console.Write("* ");
                                    }
                                    System.Console.WriteLine();
                                }
                                break;
                            }else{
                                System.Console.WriteLine("Chiều cao không hợp lệ!");
                            }
                        }
                        break;
                    case 7: 
                        System.Console.WriteLine("Thoát!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai! Vui long chon lai");
                        break;
                }
                if(choose == 7) flag = false;
            } while (flag == true);
        }
        public static void showMenu(){
            Console.WriteLine("1. In ra đoạn thẳng");
            Console.WriteLine("2. In ra hình chữ nhật");
            Console.WriteLine("3. In tam giác cân");
            Console.WriteLine("4. In tam giác vuông ngược");
            Console.WriteLine("5. In ra hình thang cân");
            Console.WriteLine("6. In ra hình thoi");
            Console.WriteLine("7. Thoát!");
            Console.WriteLine("Chon: ");
        }
    }
}

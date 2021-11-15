using System;

namespace Bai1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Boolean flag = true;
            int choose ;
            Console.WriteLine("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("May tinh co ban");
                Console.WriteLine("1. Tinh tong");
                Console.WriteLine("2. Tinh hieu");
                Console.WriteLine("3. Tinh nhan");
                Console.WriteLine("4. Tinh chia");
                Console.WriteLine("5. Tinh so du");
                Console.WriteLine("6. Tinh luy thua");
                Console.WriteLine("7 .Thoat!");
                System.Console.WriteLine("Chon : ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: 
                        int tong = a + b;
                        Console.WriteLine("Tong {0} + {1} = {2}", a, b, tong);
                        break;
                    case 2: 
                        int hieu = a - b;
                        Console.WriteLine("Hieu {0} - {1} = {2}", a, b, hieu);
                        break;
                    case 3: 
                        int nhan = a * b;
                        Console.WriteLine("Nhan {0} x {1} = {2}", a, b, nhan);
                        break;
                    case 4: 
                        if(b != 0){
                            float thuong = (float) a/b;
                            Console.WriteLine("Phep chia {0} : {1} = {2}", a, b, thuong);
                        }else{
                            Console.WriteLine("{0} phai khac 0!", b);
                        }
                        break;
                    case 5: 
                        if(b != 0){
                            int du = a % b;
                            Console.WriteLine("So du {0} / {1} = {2}", a, b, du);
                        }else{
                            Console.WriteLine("{0} phai khac 0!", b);
                        }
                        break;
                    case 6: 
                        long ketQua = 1;
                        for(int i = 1; i <= b; i++ ){
                            ketQua *= a;
                        }
                        Console.WriteLine("Luy thua {0}^{1} = {2}", a, b, ketQua);
                        break;
                    case 7: 
                        System.Console.WriteLine("Thoat chuong trinh!");
                        System.Environment.Exit(1);
                        break;
                    default:
                        System.Console.WriteLine("Nhap sai! Vui long chon lai");
                        break;
                }
                if(choose == 7) flag = false;
            } while (flag == true);

        }
    }
}

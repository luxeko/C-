using System.Collections.Generic;
using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            while (true)
            {
                System.Console.WriteLine("Nhap so phan tu cho mang: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n > 0 && n < 100) break;
                else
                    System.Console.WriteLine("Nhap sai gia tri");
            }
            string[] arr = new string[n];
            int choose;
            Boolean flag = true;
            do
            {
                showMenu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        for(int i = 0; i < n; i++)
                        {
                            System.Console.WriteLine("Nhập phần tử thứ {0}: ", i );
                            arr[i] = Console.ReadLine();
                        }
                        hienThiMang(arr);
                        break;
                    case 2:
                        Array.Resize(ref arr, arr.Length - 1);
                        hienThiMang(arr);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        System.Console.WriteLine("Thoat!");
                        break;
                    default:
                        System.Console.WriteLine("Nhap sai! vui long chon lai");
                        break;
                }
                if(choose == 5) flag = false;
            } while (flag == true);
        }
        

        static void showMenu()
        {
            System.Console.WriteLine("1. Them cac phan tu vao mang");
            System.Console.WriteLine("2. Xoa phan tu cuoi cung");
            System.Console.WriteLine("3. Nhap 1 chuoi, tim xem trong mang co bao nhieu gia tri trung va hien thi vi tri");
            System.Console.WriteLine("4. Sap xep mang tang dan, giam dan va hien thi mang");
            System.Console.WriteLine("5 Thoat!");
            System.Console.WriteLine("Chon: ");
        }
        static void hienThiMang(string[] arr )
        {
            foreach(string items in arr)
            {
                Console.Write(string.Format("{0,-15}" , items));
            }
            System.Console.WriteLine();
        }
    }
}

using System;

namespace Bai1
{
    class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            while (true)
            {
                System.Console.WriteLine("Nhap so phan tu cua mang: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n > 0 && n < 100) break;
                else
                    System.Console.WriteLine("Nhap sai gia tri");
            }
            
            int[] mang = new int[n];
            System.Console.WriteLine("Nhap cac phan tu cho mang: ");
            for(int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Nhập phần tử thứ {0}: ", i );
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            int choose;
            Boolean flag = true;
            do
            {
                showMenu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        hienThiMang(mang);
                        break;
                    case 2:
                        int demChan = 0, demLe = 0, demDuong = 0, demAm = 0;
                        for (int i = 0; i < mang.Length; i++) 
                        {
                            if (mang[i] % 2 == 0) 
                            {
                                demChan++;
                            }
                            if (mang[i] < 0) 
                            {
                                demAm++;
                            }
                            if (mang[i] >= 0) 
                            {
                                demDuong++;
                            }
                            if (mang[i] % 2 != 0) 
                            {
                                demLe++;
                            }
                        }
                        System.Console.WriteLine("So luong so chan {0}: ", demChan);
                        System.Console.WriteLine("So luong so le {0}: ", demLe);
                        System.Console.WriteLine("So luong so am {0}: ", demAm);
                        System.Console.WriteLine("So luong so duong {0}: ", demDuong);
                        break;
                    case 3:
                        int min = mang[0], max = mang[0];
                        for(int i = 0; i < mang.Length; i++)
                        {
                            if(mang[i] < min)
                            {
                                min = mang[i];
                            }
                            if(mang[i] > max)
                            {
                                max = mang[i];
                            }
                        }
                        System.Console.WriteLine("Phan tu lon nhat {0}: ", max);
                        System.Console.WriteLine("Phan tu nho nhat {0}: ", min);
                        break;
                    case 4:
                        Array.Sort(mang);
                        System.Console.WriteLine("Mang sau khi dc sap xep: ");
                        hienThiMang(mang);
                        break;
                    case 5:
                        int temp = mang[0];
                        for (int i = 0 ; i < mang.Length - 1; i++) {
                            for (int j = i + 1; j < mang.Length; j++) {
                                if (mang[i] < mang[j]) {
                                    temp = mang[j];
                                    mang[j] = mang[i];
                                    mang[i] = temp;
                                }
                            }
                        }
                        hienThiMang(mang);
                        break;
                    case 6:
                        int timPhanTu;
                        Boolean found = false;
                        System.Console.WriteLine("Nhap phan tu can tim: ");
                        timPhanTu = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < mang.Length; i++)
                        {
                            if(mang[i] == timPhanTu)
                            {
                                System.Console.WriteLine("Phan tu {0} o vi tri index {1}", timPhanTu, i);
                                found = true;
                                break;
                            }
                        }
                        if(!found) System.Console.WriteLine("Khong tim thay phan tu {0}", timPhanTu);
                        break;
                    case 7:
                        System.Console.WriteLine("Thoat!");
                        break;
                    default:
                        System.Console.WriteLine("Nhap sai! Vui long chon lai");
                        break;
                }
                if(choose == 7) flag = false;

            } while (flag == true);
        }
        static void showMenu()
        {
            System.Console.WriteLine("1. Hien thi cac phan tu cua mang");
            System.Console.WriteLine("2. Dem trong mang co bao nhieu so le, chan, am, duong");
            System.Console.WriteLine("3. Tim phan tu lon nhat va be nhat trong mang");
            System.Console.WriteLine("4. Sap xep mang tang dan va hien thi");
            System.Console.WriteLine("5. Sap xep giam dan va hien thi");
            System.Console.WriteLine("6. Nhap 1 so va tim vi tri so do trong mang");
            System.Console.WriteLine("7. Thoat");
            System.Console.WriteLine("Chon: ");
        }  
        static void hienThiMang(int[] mang)
        {
            foreach(int item in mang)
            {
                Console.Write(item + "\t");
            }
            System.Console.WriteLine();
        } 
    }
}

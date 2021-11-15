using System;
using System.Globalization;
namespace Bai2
{
    /*
        Xây dựng menu bài toán nạp/ rút tiền tại cây ATM đơn giản:
        Trong 1 tài khoản có số tiền gốc là 10000, mã pin của tk: 123456.
        Người dùng thực hiện nhập mã  pin (chuỗi từ bàn phím), so sánh với mã pin đã đúng chưa?
        + Nếu người dùng nhập sai mã pin >= 3 lần liên tiếp, thì thông báo tài khoản đã bị khóa
        + Nếu người dùng nhập sai mã pin < 3 lần, thì yêu cầu người dùng nhập lại mã pin
        + Nếu người dùng nhập đúng mã pin thì hiển thị menu:
        -	Nhập 1: Kiểm tra số dư -> in ra số tiền còn trong tài khoản có format ( dùng dấu . để format vd: 1000000 = 1,000,000)
        -	Nhập 2: Rút tiền
        	Người dùng nhập số tiền cần rút từ bàn phím, số tiền cần rút > 0 và tối thiểu rút là 50000, và số tiền cần rút thì phải là số chia hết cho 50000, sau khi rút số tiền trong tài khoản tối thiểu phải còn 10000 duy trì. Nếu tài khoản còn đủ dư thì cập nhật lại số tiền gốc tài khoản, chú ý phí rút là 1100 mỗi lần rút.
        -	Nhập 3: Nạp tiền
        	Người dùng nhập số tiền cần nạp từ bàn phím, số tiền > 0. Cập nhật lại số tiền gốc tài khoản.
        Khi người dùng thực hiện xong 1, 2, 3 hỏi ng dùng tiếp tục muốn thực hiện tiếp hay không? ( y: tiếp tục ).
    */
    class Program
    {
        static void Main(string[] args)
        {
            int tienGoc = 1000000;
            String soTien;
            int maPin;
            int soLanNhapPin = 0;
            int choose;
            Boolean flag = true;
            do
            {
                Console.WriteLine("Nhap ma pin: ");
                maPin = Convert.ToInt32(Console.ReadLine());
                if(maPin == 123456){
                    Console.WriteLine("Chao mung den voi dich vu ATM");
                    do
                    {
                        Console.WriteLine("1. Kiem tra tai khoan");
                        Console.WriteLine("2. Rut tien");
                        Console.WriteLine("3. Nap tien");
                        Console.WriteLine("4. Thoat!");
                        Console.WriteLine("Chon: ");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                soTien = tienGoc.ToString("#,##0");
                                //1.000.000
                                // Console.WriteLine("So tien trong tai khoan: {0}", soTien); 

                                //1.000.000
                                // Console.WriteLine(String.Format("{0:#,##0}", tienGoc));

                                // 1,000,000
                                Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                                "So tien trong tai khoan: {0:#,##0}", tienGoc));
                                
                                break;
                            case 2:
                                Console.WriteLine("Nhap so tien rut: ");
                                int tienRut = Convert.ToInt32(Console.ReadLine());
                                if(tienRut < 50000 ){
                                    Console.WriteLine("Tien rut khong hop le!");
                                }else if(tienRut%50000!=0){
                                    Console.WriteLine("So tien rut phai la boi so cua 50000");
                                }
                                else if(tienRut > tienGoc){
                                    Console.WriteLine("So tien trong tai khoan khong du");
                                }else {
                                    if(tienGoc > 10000 && (tienGoc - tienRut) > 10000 ){
                                        tienGoc -= tienRut;
                                        tienGoc -= 1100;
                                        Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "So tien trong tai khoan: {0:#,##0}", tienGoc));
                                    }
                                    else{
                                        Console.WriteLine("Tai khoan phai co toi thieu 10000 duy tri");
                                    }
                                } 
                                break;
                            case 3:
                                Console.WriteLine("Nhap so tien nap: ");
                                int tienNap = Convert.ToInt32(Console.ReadLine());
                                if(tienNap > 0){
                                    tienGoc += tienNap;
                                    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "So tien trong tai khoan: {0:#,##0}", tienGoc));
                                }else{
                                    Console.WriteLine("So tien nap khong hop le!");
                                }
                                break;
                            case 4:
                                System.Console.WriteLine("Thoat chuong trinh!");
                                System.Environment.Exit(1);
                                break;
                            default:
                                Console.WriteLine("Nhap sai! Vui long chon lai");
                                break;
                        }
                    
                    } while (flag == true);
                }else{
                    soLanNhapPin++;
                    if(soLanNhapPin < 4){
                        Console.WriteLine("Sai ma pin! vui long nhap lai");
                        
                    }else if(soLanNhapPin == 4){
                        Console.WriteLine("Tai khoan cua ban da bi khoa tam thoi do nhap sai ma pin qua 3 lan");
                    }
                    
                }
            } while (soLanNhapPin <= 3);
        }
    }
}

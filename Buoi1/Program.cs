using System;
using System.Globalization;

namespace Buoi1
{
    class Program
    {
        ///<sumary>
        ///Main function
        ///</sumary>
    
        static void Main(string[] args)
        {
            // int @break;
            // var myVal = 1;

            // String s = "Hello low";
            // String s1 = "";
            // Console.WriteLine(s);
            // // Nhap tu ban phim
            // Console.WriteLine("Nhap 1 ky tu");
            // int ch = Console.Read();

            // Console.WriteLine("Nhap 1 key");
            // ConsoleKeyInfo key = Console.ReadKey();
            // Console.WriteLine("Key info: " + key.Key);
            // Console.ReadLine();

            // Console.WriteLine("Nhap 1 chuoi: ");
            // String name = Console.ReadLine();

            // Console.WriteLine("Nhap 1 so nguyen: ");
            // //Su dung cac ham to....static trong class convert de chuyen doi 1 chuoi ve 1 ....
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("num1 = " + num1);
            // Console.WriteLine("num1 = {0} va chuoi nhap tu ban phim = {1}", num1, name);


            // name = "Ho va ten: " + name;
            // Console.WriteLine(name);
            // name = String.Format("{0}", name);
            // Console.WriteLine(name);

            //thoi gian
            DateTime now = DateTime.Now;
            Console.WriteLine("Hien tai: {0}", now);
            String snow = String.Format("{0:dd/MM/yyyy HH:mm}", now);
            Console.WriteLine("Hien tao {0}", snow);

            //Chuyen chuoi -> datetime
            System.Console.WriteLine("Nhap 1 ngay (dd/MM/yyyy): ");
            DateTime myBirthDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            System.Console.WriteLine("Sinh nhat cua toi: {0}", myBirthDay);
            Console.Read();
            
        }
    }
}

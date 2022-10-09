using System;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /*
    Publisher: (phát sinh ra sự kiện) nhập 1 số tu ban phim
    Subcriber: (thực hiện hành vi khi publisher phát sinh sự kiện)
        Sub1:
        - dk theo dõi
        - Publisher phát sinh sự kiện (nhập 1 số từ bàn phím) - > check số chẵn/số lẻ
        Sub2:
        - dk theo dõi
        - Publisher phát sinh sự kiện (nhập 1 số từ bàn phím) - > nhân đôi số đó
    */
    /*
    Các bước xử lý sự kiện event
        b1: tạo delegate ánh xạ tới hành vi của subcriber
        b2: tạo 1 event liên kết đến delegate này
        b3: thực hiện hành vi đăng ký theo dõi (đăng ký event)
        b4: thực thi - phát sinh sự kiện
    */
}

using System;
using System.Globalization;
namespace Bai2
{
    public class bookHouse
    {
        private Book[][] listBook;
        private String nameHouse;

        public bookHouse()
        {
            listBook = new Book[50][];
            // Khởi tạo các mảng 1 chiều trong listBook
            for(int i = 0; i < listBook.GetLength(0); i++)
            {
                Random rand = new Random();
                int shekfSize = rand.Next(10,20);
                listBook[i] = new Book[shekfSize];
            }
        }

        public bookHouse(Book[][] listBook, string nameHouse)
        {
            this.listBook = listBook;
            this.nameHouse = nameHouse;
        }

        public string NameHouse { get => nameHouse; set => nameHouse = value; }
        internal Book[][] ListBook { get => listBook; set => listBook = value; }

        public void addBook()
        {
            Book b = new Book();
            // hỏi người dùng lựa chọn kệ sạch 0 - 49
            // thêm các quyển sách vào trong listBook theo kệ sách
            while (true)
            {
                System.Console.WriteLine("Nhập kệ sách: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0 && n <= 49)
                {
                    for(int i = 0; i < listBook.GetLength(0); i++)
                    {
                        if(listBook[n] == listBook[i])
                        {
                            // b.input();
                            
                            b.input();
                            // listBook[n] = new Book[]{b.input()};
                            
                        }
                    }
                    break;
                }else System.Console.WriteLine("Kệ sách không tồn tại");
            }
           
        
        }
        public void showAllBook()
        {
            Book b = new Book();
            string str ;
            // hiển thị các sách theo kệ
            /*
                - kệ 1: 
                    + s1
                    + s2
                - kệ 2:
                    + s3
                    + s4
                    + s5
                ...    
            */
            for(int i = 0; i < listBook.GetLength(0); i++)
            {
                System.Console.WriteLine("Kệ sách {0}: ", i);
                Book[] itemBook = listBook[i];
                for(int j = 0; j < itemBook.GetLength(0); j++)
                {
                    b.output(out str);
                    System.Console.WriteLine("{0,-3}+ {1}", " ",str);
                }
            }
        }
    }
}
using System;
using System.Globalization;
namespace Bai2
{
    public class bookHouse
    {
        private Book[][] listBook;
        private int count = 0;

        public Book[][] getListBook() {
            return this.listBook;
        }
        public void setListBook(Book[][] listBook) {
            this.listBook = listBook;
        }
        public int getCount() {
            return this.count;
        }
        public void setCount(int count) {
            this.count = count;
        }


        public bookHouse()
        {
            listBook = new Book[10][];
            // Khởi tạo các mảng 1 chiều trong listBook
            for(int i = 0; i < listBook.GetLength(0); i++)
            {
                Random rand = new Random();
                int shekfSize = rand.Next(1,10);
                listBook[i] = new Book[shekfSize];
            }
        }
        public bookHouse(Book[][] listBook, int count)
        {
            this.listBook = listBook;
            this.count = count;
        }

        public void addBook()
        {
            String confirm = "";
            
            do
            {
                int keSach = 0;
                int viTri = 0;
                while (true)
                {
                    // hỏi người dùng lựa chọn kệ sạch 0 - 49
                    // thêm các quyển sách vào trong listBook theo kệ sách 
                    System.Console.WriteLine("Nhập kệ sách: ");
                    keSach = Convert.ToInt32(Console.ReadLine());
                    if(keSach >= 0 && keSach < 50){
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Kệ sách không hợp lệ!");
                    }
                }
                System.Console.WriteLine("Nhập vi tri: ");
                viTri = Convert.ToInt32(Console.ReadLine());
                
                listBook[keSach][viTri] = new Book();
                listBook[keSach][viTri].input();
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }
        
        public void showAllBook()
        {
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
                    if(listBook[i][j] != null)
                    {
                        System.Console.WriteLine(listBook[i][j].output());
                    }
                    
                    // System.Console.WriteLine("{0,-3}+ {1}", " ",str);
                }
            }
        }
    }
}
using System;
namespace Buoi4
{
    class BookHouse
    {
        private Book[][] listBook;
        private String nameHouse;

        public BookHouse()
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

        public string NameHouse { get => nameHouse; set => nameHouse = value; }
        internal Book[][] ListBook { get => listBook; set => listBook = value; }
        
        // phuong thuc nghiep vu
        public void addBook()
        {
            // hỏi người dùng lựa chọn kệ sạch 0 - 49
            // thêm các quyển sách vào trong listBook theo kệ sách
        
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
        }
    }
}
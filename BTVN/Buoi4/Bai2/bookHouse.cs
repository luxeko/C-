using System;

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
                int shekfSize = rand.Next(0,20);
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
                    if(keSach >= 0 && keSach < 20){
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Kệ sách không hợp lệ!");
                    }
                }
                while (true)
                {
                    System.Console.WriteLine("Nhập vi tri: ");
                    viTri = Convert.ToInt32(Console.ReadLine());
                    if(listBook[keSach][viTri] != null)
                    {
                        System.Console.WriteLine("Vị trí đã tồn tại sách");
                        break;
                    }
                    else{
                        listBook[keSach][viTri] = new Book();
                        listBook[keSach][viTri].input();
                        break;
                    }
                }
                
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        public void updateBook()
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
                    if(keSach >= 0 && keSach < 20)
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Kệ sách không hợp lệ!");
                    }
                }
                while (true)
                {
                    System.Console.WriteLine("Nhập vi tri: ");
                    viTri = Convert.ToInt32(Console.ReadLine());
                    if(listBook[keSach][viTri] == null)
                    {
                        System.Console.WriteLine("Vị trí chưa tồn tại sách");
                        break;
                    }
                    else{
                        listBook[keSach][viTri] = new Book();
                        listBook[keSach][viTri].input();
                        break;
                    }
                }
                
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        // in thông tin sách theo vị trí kệ
        public void showBookFromLocation()
        {
            String confirm = "";
            do
            {
                int count = 0;
                System.Console.WriteLine("Nhập vị trí kệ: ");
                int keSach = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if(keSach >= 0 && keSach < 10) break;
                    else System.Console.WriteLine("Nhập sai vị trí kệ (0 -> 9)");
                }
                for(int i = 0; i < listBook.GetLength(0); i++)
                {
                    if(listBook[keSach] == listBook[i])
                    {
                        
                        System.Console.WriteLine("Kệ sách {0}: ", keSach);
                        Book[] itemBook = listBook[keSach];
                        for(int j = 0; j < itemBook.GetLength(0); j++)
                        {
                            if(listBook[keSach][j] != null)
                            {   count++;
                                System.Console.WriteLine("{0,-3}+ {1}", " ",listBook[keSach][j].output());
                            }
                        }
                    }
                }if(count == 0) System.Console.WriteLine("Kệ sách chưa có sách");
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
            
        }

        // in vị trí và tổng số sách theo kệ
        public void showBookShelfAndTotalBooks()
        {
            String confirm = "";
            do
            {
                int count = 0;
                System.Console.WriteLine("Nhập vị trí kệ: ");
                int keSach = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if(keSach >= 0 && keSach < 10) break;
                    else System.Console.WriteLine("Nhập sai vị trí kệ (0 -> 9)");
                }
                for(int i = 0; i < listBook.GetLength(0); i++)
                {
                    if(listBook[keSach] == listBook[i])
                    {
                        
                        System.Console.WriteLine("Kệ sách {0}: ", keSach);
                        Book[] itemBook = listBook[keSach];
                        for(int j = 0; j < itemBook.GetLength(0); j++)
                        {
                            if(listBook[keSach][j] != null)
                            {
                                count++;
                            }
                        }
                    }
                }System.Console.WriteLine("Tổng số sách: {0}", count);
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
                        System.Console.WriteLine("{0,-3}+ {1}", " ",listBook[i][j].output());
                    }
                    
                }
            }
        }
    }
}
using System;

namespace Bai2
{
    public class BookHouse
    {
        private Sach[][] listBook;

        // mảng 1 chiều chứa vị trí trống tiếp theo trong từng kệ
        private int[] listViTri;

        public BookHouse()
        {
            listBook = new Sach[20][];
            listViTri = new int[listBook.GetLength(0)];
            // Khởi tạo các mảng 1 chiều trong listBook
            for(int i = 0; i < listBook.GetLength(0); i++)
            {
                Random rand = new Random();
                int shekfSize = rand.Next(10,20);
                listBook[i] = new Sach[shekfSize];
            }
        }

        internal Sach[][] ListBook { get => listBook; set => listBook = value; }
        public int[] ListViTri { get => listViTri; set => listViTri = value; }


        // phuong thuc nghiep vu
        /*
            return:
                -1: thông tin đầu vào ko đúng
                0: kệ đầy
                1: thêm thành công
        */
        public int addBook(Sach sach, int vitriKe)
        {
            // hỏi người dùng lựa chọn kệ sạch 0 - 19
            // thêm các quyển sách vào trong listBook theo kệ sách
            if(sach == null || vitriKe < 0 || vitriKe >= listBook.GetLength(0))
            {
                return -1;
            }
            Sach[] keSach = listBook[vitriKe];
            int vitriTrongTiepTheo = this.listViTri[vitriKe];
            if(vitriTrongTiepTheo >= keSach.GetLength(0))
            {
                return 0;
            }
            System.Console.WriteLine("Số vị trí tiếp theo là: " + vitriTrongTiepTheo+1);
            listBook[vitriKe][vitriTrongTiepTheo] = sach;
            this.listViTri[vitriKe] = ++vitriTrongTiepTheo;
            return 1;
        }

        public void showAll()
        {
            for(int i = 0; i < this.listBook.GetLength(0); i++)
            {
                System.Console.WriteLine("- Kệ sách {0} hiện có {1} quyển sách: ", i, listViTri[i]);
                for(int j = 0; j < listViTri[i]; j++)
                {
                    Sach book = this.listBook[i][j];
                    String ttBook;
                    book.output(out ttBook);
                    // System.Console.WriteLine("{0,-3}+ {1}", " ",listBook[i][j].output());
                    
                }
            }
        }

        // Hàm check trùng ID
        public Boolean checkID(string id)
        {
            // duyệt từng kệ
            for(int i = 0; i < this.listBook.GetLength(0); i++)
            {
                //duyệt từng vị trí
                for(int j = 0; j < this.listBook[i].GetLength(0); j++)
                {
                    Sach b = this.listBook[i][j];
                    if(b.BookID.Equals(id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
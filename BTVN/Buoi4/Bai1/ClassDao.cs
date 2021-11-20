using System;
namespace Bai1
{
    public class ClassDao
    {
        lopHoc[] quanLyLopHoc = new lopHoc[20];
        private int count = 0;

        public lopHoc[] getQuanLyLopHoc() {
            return this.quanLyLopHoc;
        }

        public void setQuanLyLopHoc(lopHoc[] quanLyLopHoc) {
            this.quanLyLopHoc = quanLyLopHoc;
        }
        public ClassDao()
        {
            // quanLyLopHoc = new lopHoc[20];
            
        }
        public ClassDao(lopHoc[] quanLyLopHoc, int count)
        {
            this.quanLyLopHoc = quanLyLopHoc;
            this.count = count;
        }
        public void addClass(){
            lopHoc lh = new lopHoc();
            lh.input();
            this.quanLyLopHoc[this.count++] = lh;
        }
        public void showList()
        {
            System.Console.WriteLine("Ds các lớp học");
            for(int i = 0; i < this.count; i++)
            {
                System.Console.WriteLine("Lớp học thứ {0}: ", (i+1));
                System.Console.WriteLine(this.quanLyLopHoc[i].output());
            }
        }
    }
}
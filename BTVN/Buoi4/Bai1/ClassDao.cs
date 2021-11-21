using System;
namespace Bai1
{
    public class ClassDao
    {
        lopHoc[] quanLyLopHoc = new lopHoc[20];
        private int count = 0;

        public int getCount() {
            return this.count;
        }

        public void setCount(int count) {
            this.count = count;
        }

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
        public void showAllList()
        {
            System.Console.WriteLine("Ds các lớp học");
            for(int i = 0; i < this.count; i++)
            {
                System.Console.WriteLine("Lớp học thứ {0}: ", (i+1));
                System.Console.WriteLine(this.quanLyLopHoc[i].output());
            }
        }

        //nhap 1 ma lop roi tra ve lop hoc co malop = malop nhap
        public lopHoc searchClassByID()
        {
            System.Console.WriteLine("Nhập mã lớp: ");
            String idFind = Console.ReadLine();
            for(int i = 0; i < this.count; i++)
            {
                lopHoc lh = this.quanLyLopHoc[i];
                if(idFind.Equals(lh.getClassID()))
                {
                    return lh;
                }
            }
            return null;
        }

        //sap xem giam dan lop hoc theo ten
        public void sortListById()
        {
            lopHoc lh;
            for(int i = 0; i < this.count-1; i++)
            {
                for(int j = i+1; j < this.count; j++)
                {
                    // so sánh giảm dần
                    if(this.quanLyLopHoc[i].getClassName().CompareTo(this.quanLyLopHoc[j].getClassName()) < 0)
                    {
                    //So sanh tang dan
                    //if(this.quanLyLopHoc[i].getMaLop().compareTo(this.quanLyLopHoc[j].getMaLop())>0){
                        lh = this.quanLyLopHoc[i];
                        this.quanLyLopHoc[i] = this.quanLyLopHoc[j];
                        this.quanLyLopHoc[j] = lh;
                    }
                }
            }
        }

        // tính số lượng học viên và số lượng lớp học
        public void sumStudentsAndClasses()
        {
            int sum = 0;
            int quantity;
            // So luong lop hoc
            for(quantity = 0; quantity < this.count; quantity++)
            {
                quantity++;
            }
            // Số lượng học viên của các lớp
            for(int i = 0; i < this.count; i++)
            {
                sum += this.quanLyLopHoc[i].getStudents();
            }
            System.Console.WriteLine("Tổng số lớp học: {0}", quantity);
            System.Console.WriteLine("Tổng số học sinh: {0}", sum);
        }

    }
}
using System;
namespace Bai1
{
    public class ClassDao
    {
        // -------- Field ----------
        lopHoc[] quanLyLopHoc;
        private int count = 0;

        // --------- Constructor --------
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
            quanLyLopHoc = new lopHoc[20];
        }
        public ClassDao(lopHoc[] quanLyLopHoc, int count)
        {
            this.quanLyLopHoc = quanLyLopHoc;
            this.count = count;
        }

        // --------- METHOD -----------
        public void addClass(){
            String confirm = "";
            do
            {
                lopHoc lh = new lopHoc();
                lh.input();
                this.quanLyLopHoc[this.count++] = lh;
                System.Console.WriteLine("Bạn có muốn tiếp tục ko? (bấm n: thoát!)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
            
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
        public lopHoc searchClassByID(String idFind)
        {
            
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
            int quantity = 0;
            // So luong lop hoc
            for(int i = 0; i < this.count; i++)
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

        // lớp có số lượng học viên nhỏ nhất và lớn nhất
        public void minMax()
        {
            int min = this.quanLyLopHoc[0].getStudents();
            int max = this.quanLyLopHoc[0].getStudents();
            String posMin = this.quanLyLopHoc[0].getClassID();
            String posMax = this.quanLyLopHoc[0].getClassID();
            for(int i = 0; i < this.count; i++)
            {
                if(min > this.quanLyLopHoc[i].getStudents())
                {
                    min = this.quanLyLopHoc[i].getStudents();
                    posMin = this.quanLyLopHoc[i].getClassID();
                }
                if(max < this.quanLyLopHoc[i].getStudents())
                {
                    max = this.quanLyLopHoc[i].getStudents();
                    posMax = this.quanLyLopHoc[i].getClassID();
                }
            }
            System.Console.WriteLine("Lớp {0} có số lượng học viên nhỏ nhất là : {1}", posMin, min);
            System.Console.WriteLine("Lớp {0} có số lượng học viên lớn nhất là : {1}", posMax, max);
        }

        // Sắp xếp ds lớp tăng dần theo số học viên
        public void sortHocVien()
        {
            lopHoc temp2;
            for(int i = 0; i < this.count; i++)
            {
                for(int j = i+1; j < this.count; j++)
                // sắp xếp số lượng học viên tăng dần
                {
                    if(this.quanLyLopHoc[i].getStudents() > this.quanLyLopHoc[j].getStudents())
                    {
                        temp2 = this.quanLyLopHoc[i];
                        this.quanLyLopHoc[i] = this.quanLyLopHoc[j];
                        this.quanLyLopHoc[j] = temp2;
                    }
                }
            }
        }

    }
}
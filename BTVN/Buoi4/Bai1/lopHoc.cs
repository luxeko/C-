using System.Linq;
using System;

namespace Bai1
{
    public class lopHoc
    {
        private String classID;
        private String className;
        private int Students;
        private int year;

        public string getClassID() {
            return this.classID;
        }
        public void setClassID(String classID) {
            this.classID = classID;
        }
        public string getClassName() {
            return this.className;
        }
        public void setClassName(String className) {
            this.className = className;
        }
        public int getStudents() {
            return this.Students;
        }
        public void setStudents(int Students) {
            this.Students = Students;
        }
        public int getYear() {
            return this.year;
        }
        public void setYear(int year) {
            this.year = year;
        }
        public lopHoc()
        {
        }
        public lopHoc(String classID, String className, int students, int year)
        {
            this.classID = classID;
            this.className = className;
            Students = students;
            this.year = year;
        }

        public void input()
        {
            // ClassDao cd = new ClassDao();
            // while (true)
            // {
            //     int count = 0;
            //     System.Console.WriteLine("Nhập mã lớp học: ");
            //     this.classID = Console.ReadLine();
            //     if(this.classID.Trim().Equals(""))
            //     {
            //         System.Console.WriteLine("Bạn chưa nhập ID lớp");
            //     }
            //     else
            //     {
            //         for(int i = 0; i < cd.getQuanLyLopHoc().GetLength(0); i++)
            //         {
            //             lopHoc checkID = cd.getQuanLyLopHoc()[i];
            //             if(this.classID.Equals(checkID.getClassID()))
            //             {
            //                 System.Console.WriteLine("Mã lớp học đã tồn tại!");
            //                 count++;
            //             }
            //         }
            //         if(count == 0) break;
            //     }
                
            // }
            // while (true)
            // {
            //     int count = 0;
            //     System.Console.WriteLine("Nhập tên lớp học: ");
            //     this.className = Console.ReadLine();
            //     foreach(lopHoc lh in cd.getQuanLyLopHoc())
            //     {
            //         if(this.className.Equals(lh.getClassName()))
            //         {
            //             System.Console.WriteLine("Tên lớp học đã tồn tại!");
            //             count++;
            //         }
            //     }if(count == 0) break;
            // }
            System.Console.WriteLine("Nhập mã lớp học: ");
            this.classID = Console.ReadLine();
            System.Console.WriteLine("Nhập tên lớp học: ");
            this.className = Console.ReadLine();
            while (true)
            {
                System.Console.WriteLine("Nhập số lượng học sinh: ");
                this.Students = Convert.ToInt32(Console.ReadLine());
                if(this.Students <= 0){
                    System.Console.WriteLine("Số lượng học sinh không hợp lệ");
                }else break;
            }
            while (true)
            {
                System.Console.WriteLine("Nhập năm học: ");
                this.year = Convert.ToInt32(Console.ReadLine());
                if(this.year < 0){
                    System.Console.WriteLine("Năm học không hợp lệ");
                }else break;
            }
        }

        public String output()
        {
            return "ID: " + this.classID + ", " +
                    "NameClass: " + this.className + ", " +
                    "Students: " + this.Students + ", " +
                    "Year: " + this.year;
        }
    }
}
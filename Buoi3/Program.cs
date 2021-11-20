using System;

namespace Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---- Mảng 1 chiều ----");
            // Mảng 1 chiều: các phần tử cùng kiểu được lưu trữ trên cùng 1 hàng.
            // mang1Chieu();

            // Mảng đa chiều:
            // 1. Mảng hình chữ nhật - rectangur: kích thước của mỗi chiều là cố định, số chiều = số dấu, trong [] + 1
            // MangRectangur();

            // 2. Mảng răng cưa - jagged: 1 mảng chứa các mảng khác, cố định số hàng trong mảng, số cột sẽ linh động 
            MangJagged();
            Console.Read();

        }

        static void MangJagged()
        {
            String[][] dsHvNam2021 = new String[4][];
            // lop t2101e
            dsHvNam2021[0] = new string[10];
            // lop t2102e
            dsHvNam2021[1] = new string[15];
            // lop t2103e
            dsHvNam2021[2] = new string[]{"DucAnh", "MaiTrang", "HongThai"};
            // lop t2101e
            dsHvNam2021[3] = new string[14];
            for(int i = 0; i < dsHvNam2021.GetLength(0); i++)
            {
                String[] itemJagged = dsHvNam2021[i];
                for(int j = 0; j < itemJagged.GetLength(0); j++)
                {
                    System.Console.Write((itemJagged[j]==null?"N/A":itemJagged[j]) + "\t");
                }
                System.Console.WriteLine();
            }
            int [][] mang2chieuJagged = new int[4][];
            mang2chieuJagged [0] = new int[3];
            mang2chieuJagged [1] = new int[3];
            mang2chieuJagged [2] = new int[3];
            mang2chieuJagged [3] = new int[3];

        }

        static void MangRectangur()
        {
            // Khai báo và khởi tạo kích thước mảng 2 chiều hình chữ nhật
            // toà nhà chung cư có 5 tầng/hàng và mỗi tầng/hàng có 3 căn hộ/cột
            string[,] ccT21 = new string[5, 3];
            for(int i = 0; i < ccT21.GetLength(0); i++)
            {
                for(int j = 0; j < ccT21.GetLength(1); j++)
                {
                    ccT21[i, j] = "T" + (i + 1) + (j + 1);
                    Console.Write(ccT21[i,j] + "\t");
                }
                System.Console.WriteLine();
            }

            int[,,,] mang4Chieu = new int[3, 4, 5, 6];
            for(int i = 0; i < mang4Chieu.GetLength(0); i++)
            {
                for(int j = 0; j < mang4Chieu.GetLength(1); j++)
                {
                    for(int k = 0; k < mang4Chieu.GetLength(2); k++)
                    {
                        for(int m = 0; m < mang4Chieu.GetLength(3); m++)
                        {
                            mang4Chieu[i,j,k,m] = (i+1)*1000 + (j+1)*100 + (k+1)*10 + (m+1);
                            System.Console.Write(mang4Chieu[i,j,k,m] + "\t");
                        }
                        System.Console.WriteLine();
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();
            }
        }
        static void mang1Chieu()
        {
            // Khai báo và khởi tạo
            int[] nums = new int[20]; //20 phần tử số nguyên có giá trị mặc định = 0
            Console.WriteLine("Size: " + nums.Length);
            Random rand = new Random();
            for(int i = 0; i < nums.Length; i++)
            {
                int randomNum = rand.Next(0,9);
                // nums[i] = randomNum;
                nums.SetValue(randomNum, i);
            }
            Console.WriteLine("Hiển thị ds mảng: ");
            foreach(int item in nums)
            {
                Console.Write(item + "\t");
            }
            System.Console.WriteLine();

            Array.Sort(nums);
            Console.WriteLine("Hiển thị ds mảng sau khi sắp xếp: ");
            foreach(int item in nums)
            {
                Console.Write(item + "\t");
            }
            System.Console.WriteLine();

            Array.Sort(nums, new sortTangGiam());
            Console.WriteLine("Hiển thị ds mảng sau khi sắp xếp: ");
            foreach(int item in nums)
            {
                Console.Write(item + "\t");
            }
            System.Console.WriteLine();
        }
    }
    class sortTangGiam : System.Collections.IComparer
    {
        /*
            Kết quả:
                - = 0: x = y
                - < 0: x < y
                - > 0: x > y
        */
        public int Compare(object x, object y)
        {
            int xx = (int)x;
            int yy = (int)y;
            //2 so chan thi giam dan
            if(xx%2==0 && yy%2==0){
                return yy.CompareTo(xx);
            }
            //2 so le thi tang dan
            else if(xx%2!=0 && yy%2!=0){
                return xx.CompareTo(yy);
            }
            //so thu nhat chan, so thu 2 le thi tang dan
            else if(xx%2==0 && yy%2!=0){
                return -1;
            }
            //so thu nhat le, so thu 2 chan thi giam dan
            else {
                return 1;
            }
        }
    }
}

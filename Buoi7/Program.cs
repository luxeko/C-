using System;
using System.IO;

namespace Buoi7
{
    
    class Program
    {
        static void Main(string[] args)
         {
            System.Console.WriteLine("Read file: ");
            try
            {
                
                //b1: tạo stream kết nối tới nguồn dữ liệu
                using (StreamReader sr = new StreamReader("E:\\CSharp\\Buoi7\\dsbook.txt", System.Text.Encoding.UTF8))
                {
                    //b2: thực thi
                    string line = "";
                    while((line = sr.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                        //validate line -> book hop le: id ko trung nhau, name != null, titile, price, float > 0, publishdate: datetime
                        // book hop le: them vao list<book>
                    }
                }
                
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Loi" + e.Message);
            }
            System.Console.WriteLine("End read file");
            Console.ReadLine();
        }
        static void Main_ReadFile()
        {
            StreamReader sr = null;
            try
            {
                //b1: tạo stream kết nối tới nguồn dữ liệu
                sr = new StreamReader("E:\\CSharp\\Buoi7\\dsbook.txt", System.Text.Encoding.UTF8);
                //b2: thực thi
                string line = "";
                while((line = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Loi" + e.Message);
            }
            finally
            {
                if(sr!=null) sr.Close();
            }
            System.Console.WriteLine("End read file");
            Console.ReadLine();
        }
        static void Main_Exception()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Exception Demo");
            int num1 = 0;
            float num2 = 0;
            while (true)
            {
                // System.Console.WriteLine("Nhap so nguyen 1: ");
                // try
                // {
                //     // khối code
                //     num1 = Convert.ToInt32(Console.ReadLine());
                //     break;
                // }
                // catch (System.Exception ex)
                // {
                //     System.Console.WriteLine("Không phải số! Nhập lại");
                // }
                if(!int.TryParse(Console.ReadLine(), out num1)) System.Console.WriteLine("Ko phải là số! Nhập lại");
                else break;
            }
            while (true)
            {
                System.Console.WriteLine("Nhập 1 số float: ");
                bool check = float.TryParse(Console.ReadLine(), out num2);
                if(check ) break;
                else System.Console.WriteLine("Không phải là float! Nhập lại");
            }
            // System.Console.WriteLine(ThrowDemo());
            try
            {
                System.Console.WriteLine("ThrowDemo kết quả: " + ThrowDemo());
            }catch(NullReferenceException ex)
            {
                System.Console.WriteLine("Err: " + ex.Message);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Err: " + ex.Message);
            }

            Exception e;
            if(TryParseDemo(out num1, out e)) System.Console.WriteLine("Num1: " + num1);
            else System.Console.WriteLine("Có lỗi trong quá trình thực hiện hàm: " + e.Message);
            Console.ReadLine();
        }

        /*
        Không lỗi: return true, num: giá trị đúng, err == null
        Có lỗi: return false, num: giá trị sai, err != null
        */
        static bool TryParseDemo(out int num, out Exception err)
        {
            num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                err = null; 
                return true;
            }
            catch (System.Exception)
            {
                // tung ra 1 đối tượng ngoại lệ
                err = new Exception("Không phải là số nguyên");
            }
            if(num <= 0)
            {
                err = new Exception("Số nguyên không đc <= 0");
            }
            return false;
        }
        static int ThrowDemo()
        {
            int num1 = 0;
            System.Console.WriteLine("Nhap so nguyen: ");
            try
            {
                
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                // tung ra 1 đối tượng ngoại lệ
                throw new Exception("Không phải là số nguyên");
            }
            if(num1 <= 0)
            {
                throw new Exception("Số nguyên không đc <= 0");
            }
            return num1;
            
        }
    }
}

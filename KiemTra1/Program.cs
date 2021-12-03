using System;

namespace KiemTra1
{
    class Program
    {
        private static string name;
        private static int age;

        

        static void Main(string[] args)
        {
            intput();
        }
        static void intput()
        {
            string confirm = "";
            do
            {
                while (true)
                {
                    System.Console.WriteLine("Nhập tên: ");
                    name = Console.ReadLine();
                    if(name.Trim().Equals("")) System.Console.WriteLine("Tên không được để rỗng!");
                    else break;

                }
                while (true)
                {
                    try
                    {
                        System.Console.WriteLine("Nhập tuổi: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        if(age > 0) break;
                        else System.Console.WriteLine("Tuổi phải > 0");
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Tuổi phải là kiểu số");
                    }
                }
                System.Console.WriteLine("Simple Properties Demo");
                System.Console.WriteLine("Person details - Name = {0}, Age = {1}", name, age);
                age +=1;
                System.Console.WriteLine("Person details <After incrementing age> - Name = {0}, Age = {1}", name, age);
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }
    }
}

using System.Text.RegularExpressions;
using System;

namespace KiemTra2
{
    class Program
    {
        static void Main(string[] args)
        {   
            string chuoi;
            string keyword;
            string confirm = "";
            do
            {
                System.Console.WriteLine("Enter a String: ");
                chuoi = Console.ReadLine(); 
                if(chuoi.Trim().Equals("")) System.Console.WriteLine("Chuỗi không được để rỗng");
                else
                {
                    do
                    {
                        int Count = 0;  
                        System.Console.WriteLine("Enter a word to search: ");
                        keyword = Console.ReadLine();
                        foreach (Match m in Regex.Matches(chuoi, keyword))  
                        {  
                            Count++;  
                        } 
                        Console.WriteLine("Keyword \"{0}\" xuất hiện: {1} lần", keyword, Count); 
                        System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                        confirm = Console.ReadLine();
                    } while (!confirm.Equals("n"));
                }
                System.Console.WriteLine("Bạn có muốn tạo chuỗi mới? (Bấm n : stop)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n")); 
        }

    }
}

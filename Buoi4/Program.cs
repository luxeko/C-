using System;
namespace Buoi4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book b = new Book();
            //set
            b.Name = "Conan";
            // b.Publish = DateTime.Now;
            System.Console.WriteLine(b.Name);
            System.Console.WriteLine("Biến tĩnh: " + Book.className + "; " + Book.cate);

            // string str = " " ;
            string str ;
            // b.output(ref str);
            b.output(out str);
            System.Console.WriteLine(str);
        }
    }
}
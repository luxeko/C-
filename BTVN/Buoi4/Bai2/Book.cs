using System;
using System.Globalization;
namespace Bai2
{
    public class Sach
    {
        private string bookID;	    
        private string name;
        private int price;
        private string author;
        private DateTime publish;

        public Sach()
        {
        }
        public Sach(string bookID, string name, int price, string author, DateTime publish)
        {
            this.bookID = bookID;
            this.name = name;
            this.price = price;
            this.author = author;
            this.publish = publish;
        }
        public string BookID { get => bookID; set => bookID = value; }

        public void input(ref BookHouse nhaSach)
        {
            while (true)
            {
                System.Console.WriteLine("Nhập ID: ");
                this.BookID = Console.ReadLine();
                //check trùng id
                bool checkTrung = nhaSach.checkID(this.BookID);
                if(checkTrung == false)
                {
                    System.Console.WriteLine("Name: ");
                    this.name = Console.ReadLine();
                    System.Console.WriteLine("Price: ");
                    this.price = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Author: ");
                    this.author = Console.ReadLine();
                    System.Console.WriteLine("Publish date: ");
                    this.publish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    break;
                }
                else if(checkTrung == true)
                {
                    System.Console.WriteLine("ID {0} đã tồn tại! vui lòng nhập lại", this.BookID);
                }
            }
        }
        public void inputUpdate(ref BookHouse nhaSach)
        {
            
            while (true)
            {
                System.Console.WriteLine("Nhập ID mới: ");
                this.BookID = Console.ReadLine();
                //check trùng id
                bool checkTrung = nhaSach.checkID(this.BookID);
                if(checkTrung == true)
                {
                    System.Console.WriteLine("Name: ");
                    this.name = Console.ReadLine();
                    System.Console.WriteLine("Price: ");
                    this.price = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Author: ");
                    this.author = Console.ReadLine();
                    System.Console.WriteLine("Publish date: ");
                    this.publish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    break;
                }
                else if(checkTrung == false)
                {
                    System.Console.WriteLine("ID {0} đã tồn tại! vui lòng nhập lại", this.BookID);
                }
            }
        }

        public void output(out string param)
        {
            param = "  + " + "ID: " + this.BookID + ", " + "Name: " + this.name + ", " + "Price: " + this.price + ", " + "Author: " + this.author + ", " + "PublishDate: " + String.Format("{0:dd/MM/yyyy}", this.publish);
            System.Console.WriteLine(param);
        
            // return "ID: " + this.BookID + ", "
            //         + "Name: " + this.name + ", "
            //         + "Price: " + this.price + ", "
            //         + "Author: " + this.author + ", "
            //         + "Publish: " + String.Format("{0:dd/MM/yyyy}", this.publish) ;
        }
    }
}
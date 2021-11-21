using System;
using System.Globalization;
namespace Bai2
{
    public class Book
    {
        private string bookID;
        private string name;
        private int price;
        private string author;
        private DateTime publish;

        public string getBookID() {
            return this.bookID;
        }
        public void setBookID(string bookID) {
            this.bookID = bookID;
        }
        public string getName() {
            return this.name;
        }
        public void setName(string name) {
            this.name = name;
        }
        public int getPrice() {
            return this.price;
        }
        public void setPrice(int price) {
            this.price = price;
        }
        public string getAuthor() {
            return this.author;
        }
        public void setAuthor(string author) {
            this.author = author;
        }
        public DateTime getPublish() {
            return this.publish;
        }
        public void setPublish(DateTime publish) {
            this.publish = publish;
        }

        public Book()
        {
        }
        public Book(string bookID, string name, int price, string author, DateTime publish)
        {
            this.bookID = bookID;
            this.name = name;
            this.price = price;
            this.author = author;
            this.publish = publish;
        }

        //---------Constructor------        

        public void input()
        {
            System.Console.WriteLine("ID: ");
            this.bookID = Console.ReadLine();
            System.Console.WriteLine("Name: ");
            this.name = Console.ReadLine();
            System.Console.WriteLine("Price: ");
            this.price = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Author: ");
            this.author = Console.ReadLine();
            System.Console.WriteLine("Publish date: ");
            this.publish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        public String output()
        {
            return "ID: " + this.bookID + ", "
                    + "Name: " + this.name + ", "
                    + "Price: " + this.price + ", "
                    + "Author: " + this.author + ", "
                    + "Publish: " + String.Format("{0:dd/MM/yyyy}", this.publish) ;
        }
    }
}
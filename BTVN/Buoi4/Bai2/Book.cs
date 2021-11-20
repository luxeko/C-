using System;
using System.Globalization;
namespace Bai2
{
    public class Book
    {
        private string name;
        private int price;
        private string author;
        private DateTime publish;

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
        public Book(string name, int price, string author, DateTime publish)
        {
            this.name = name;
            this.price = price;
            this.author = author;
            this.publish = publish;
        }

        
        
        public void input()
        {
            System.Console.WriteLine("Name: ");
            this.name = Console.ReadLine();
            System.Console.WriteLine("Price: ");
            this.price = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Author: ");
            this.author = Console.ReadLine();
            System.Console.WriteLine("Publish date: ");
            this.publish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        public void output(out string param)
        // public void output(ref string param)
        {
            param = this.name + ", " + this.author + ", " + this.price + ", " + this.publish;
            // System.Console.WriteLine("Name: {0}, Price: {1}, Author: {2}, Publish: {3}", this.name, this.price, this.author, this.publish);
        }
    }
}
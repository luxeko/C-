using System;
namespace Assignment
{
    public class Products
    {
        private int id = 0;
        private string codePr;
        private string namePr;
        private float price;

        public Products()
        {
        }

        public Products(int id, string codePr, string namePr, float price)
        {
            this.id = id;
            this.codePr = codePr;
            this.namePr = namePr;
            this.price = price;
        }

        public int Id { get => id; set => id = value; }
        public string CodePr { get => codePr; set => codePr = value; }
        public string NamePr { get => namePr; set => namePr = value; }
        public float Price { get => price; set => price = value; }

        public void input()
        {
        
            System.Console.WriteLine("Nhập mã sản phẩm: ");
            this.codePr = Console.ReadLine();
            System.Console.WriteLine("Nhập tên sản phẩm: ");
            this.namePr = Console.ReadLine();
            System.Console.WriteLine("Nhập giá sản phẩm: ");
            this.price = Convert.ToSingle(Console.ReadLine());
            
            this.id++;
            
        }

        public override string ToString()
        {
            return "ID: " + this.id + ", Code: " + this.codePr + ", Name: " + this.namePr + ", Price: " + this.price;
        }
    }
    
}
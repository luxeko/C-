using System;
namespace Assignment
{
    public class Products
    {
        private int id = 1;
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

        public virtual void input(ProductsDAO dsSanPham)
        {
            while (true)
            {
                int count = 0;
                System.Console.WriteLine("Nhập mã sản phẩm: ");
                this.codePr = Console.ReadLine();
                if(this.codePr.Length == 4){
                    foreach(Products pr in dsSanPham.ListPr)
                    {
                        if(this.codePr.Equals(pr.CodePr))
                        {
                            System.Console.WriteLine("Mã sản phẩm đã tồn tại!");
                            count++;
                        }
                    }
                    if(count == 0)break;
                }
                else System.Console.WriteLine("Mã sản phẩm phải có 4 ký tự !");
            }
            while (true)
            {
                System.Console.WriteLine("Nhập tên sản phẩm: ");
                this.namePr = Console.ReadLine();
                if(this.namePr.Trim().Equals("")) System.Console.WriteLine("Tên sản phẩm không được để rỗng");
                else break;
            }
            try
            {
                System.Console.WriteLine("Nhập giá sản phẩm: ");
                this.price = Single.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Giá tiền không hợp lệ!");
            }
            while (true)
            {
                int count = 0;
                foreach(Products sp in dsSanPham.ListPr)
                {
                    if(this.id == sp.Id)
                    {
                        this.id ++;
                        count++;
                    }
                }
                if(count == 0) break;
            }
            
        }

        public override string ToString()
        {
            return "ID: " + this.id + ", Code: " + this.codePr + ", Name: " + this.namePr + ", Price: " + this.price;
        }
    }
    
}
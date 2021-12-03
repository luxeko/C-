using System;
namespace Assignment
{
    public class Vegestable : Products
    {
        private string category;
        DateTime created_date;
        DateTime update_date;

        public Vegestable()
        {
        }
        public Vegestable(int id, string codePr, string namePr, float price, string category, DateTime created_date, DateTime update_date) : base(id, codePr, namePr, price)
        {
            this.category = category;
            this.created_date = created_date;
            this.update_date = update_date;
        }

        public string Category { get => category; set => category = value; }
        public DateTime Created_date { get => created_date; set => created_date = value; }
        public DateTime Update_date { get => update_date; set => update_date = value; }


        public override void input(ProductsDAO dsSanPham)
        {
            base.input(dsSanPham);
            while (true)
            {
                System.Console.WriteLine("Nhóm sản phẩm: ");
                this.category = Console.ReadLine();
                if(this.category.Trim().Equals("")) System.Console.WriteLine("Nhóm sản phẩm không được rỗng");
                else break;
            }
            this.created_date = DateTime.Now;
            this.update_date = DateTime.Now;
        }

        public override string ToString()
        {
            return base.ToString() + ", Nhóm sản phẩm: " + this.category + ", Ngày tạo: " + this.created_date;;
        }
    }
}
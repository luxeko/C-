using System.Collections.Generic;
using System;

namespace Assignment
{
    public class Combo : Products
    {
        private string status;
        List<Vegestable> vegestables;

        public Combo()
        {
            Vegestables = new List<Vegestable>();
        }

        public Combo(int id, string codePr, string namePr, float price, string status, List<Vegestable> vegestables) : base(id, codePr, namePr, price)
        {
            this.status = status;
            this.Vegestables = vegestables;
        }

        public string Status { get => status; set => status = value;}
        public List<Vegestable> Vegestables { get => vegestables; set => vegestables = value; }

        public override void input(ProductsDAO dsPr)
        {
            base.input(dsPr);
            int choose;
            while (true)
            {
                System.Console.WriteLine("Chọn trạng thái (1. Active / 0. Unactive): ");
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                    if(choose == 1) 
                    {
                        this.status = "Active";
                        break;
                    }
                    else if(choose == 0)
                    {
                        this.status = "Unactive";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Vui lòng chọn lại!");
                    }
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Lựa chọn không hợp lệ");
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Status: " + this.status;
        }
    }
}
using System.Collections.Generic;
using System;
namespace Assignment
{
    public class VegesDAO
    {
        List<Vegestable> listVG;

        public VegesDAO()
        {
            listVG = new List<Vegestable>();
        }

        public VegesDAO(List<Vegestable> listVG)
        {
            this.listVG = listVG;
        }

        public List<Vegestable> ListVG { get => listVG; set => listVG = value; }

        
        // Add vegestable 
        public void addVeg(Vegestable veg, ProductsDAO dsPr)
        {
            if(veg == null)
            {
                System.Console.WriteLine("Thêm vegestable thất bại");
            }
            else
            {
                listVG.Add(veg);
                dsPr.ListPr.Add(veg);
            }
        }

        // In danh sach vegestable
        public void inDanhSachVG()
        {
            if(listVG != null)
            {
                foreach(Vegestable vg in listVG)
                {
                    System.Console.WriteLine("- {0}",vg.ToString());
                }
            }
            else
            {
                System.Console.WriteLine("Danh sách trống");
            }
        }

        // Tìm kiếm
        public void searchVg()
        {
            string maTimKiem;
            string confirm = "";
            do
            {
                int count = 0;
                System.Console.WriteLine("Nhập mã tìm kiếm: ");
                maTimKiem = Console.ReadLine();
                foreach(Vegestable vg in listVG)
                {
                    if(maTimKiem.Equals(vg.CodePr))
                    {
                        System.Console.WriteLine(vg.ToString());
                        count++;
                    }
                }
                if(count == 0) System.Console.WriteLine("Vegestable không tồn tại");
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        // Update 
        public void updateVg()
        {
            int count = 0;
            string confirm = "";
            string maVeges;
            do
            {
                System.Console.WriteLine("Nhập mã vegestable: ");
                maVeges = Console.ReadLine();
                foreach(Vegestable vg in listVG)
                {
                    if(maVeges.Equals(vg.CodePr))
                    {
                        vg.inputUpdate();
                        count++;
                    }
                }if(count == 0) System.Console.WriteLine("Vegestable không tồn tại");
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }

        // In mã vegestable
        public void inCodeVegestable()
        {
            if(listVG != null)
            {
                System.Console.WriteLine("List mã vegestable: ");
                foreach(Vegestable vg in listVG)
                {
                    System.Console.Write(string.Format("{0,-6}", vg.CodePr));
                }
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Danh sách trống");
            }
        }

    }
}
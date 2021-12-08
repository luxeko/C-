using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class VegestableImpl
    {
        public static List<Vegestable> VegestableList { get; set; }
        public static bool AddVegestable(Vegestable vegestable)
        {
            vegestable.Input(false);
            VegestableList.Add(vegestable);
            ProductImpl.ProductList.Add(vegestable);
            return true;
        }
        public static void ShowAllVegestable(List<Vegestable> vegestableList)
        {
            foreach (Vegestable item in vegestableList)
                //Console.WriteLine(item.ToString());
                item.Output();
        }
        public static Vegestable SearchVegestableByCode(string code)
        {
            foreach (Vegestable item in VegestableImpl.VegestableList)
            {
                if (code.Equals(item.Code))
                {
                    return item;
                }
            }
            return null;
        }
        /*
        true: update successed
        false: Invalid code
         */
        public static bool UpdateVegestableByCode()
        {
            string code;
            Vegestable other = new Vegestable();
            Console.Write("Enter vegestable code to update: ");
            code = Console.ReadLine();
            if (code != null)
            {
                Vegestable vegestable = VegestableImpl.SearchVegestableByCode(code);
                //bằng null: không tìm thấy kết quả
                if (vegestable == null)
                    return false;
                else
                //khác null: tìm thấy kết quả -> gán giá trị mới
                {
                    Console.WriteLine("Vegestable found: ");
                    vegestable.Output();
                    Console.WriteLine("Input information to update: ");
                    other.Id = vegestable.Id;
                    other.Input(true);
                    vegestable.Code = other.Code;
                    vegestable.Name = other.Name;
                    vegestable.Price = other.Price;
                    vegestable.Category = other.Category;
                    vegestable.UpdateDate = other.UpdateDate;
                    ProductImpl.ShowAllProduct();
                    return true;
                }
            }
            return false;
        }
        public static bool IsVegestable(string vegesCode)
        {
            foreach (Vegestable item in VegestableList)
            {
                if (item.Code == vegesCode)
                    return true;
            }
            return false;
        }
    }
}

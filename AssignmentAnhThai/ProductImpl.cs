using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class ProductImpl
    {
        public static List<Product> ProductList { get; set; }
        /*
        true: code hợp lệ (chưa trùng)
        false: code không hợp lệ (đã trùng)
         */
        public static bool ValidateCode(string code, int id)
        {
            foreach (Product item in ProductImpl.ProductList)
            {
                if (item.Code == code && item.Id == id)
                    return true;
                if (item.Code == code)
                    return false;   
            }
            return true;
        }
        public static void AddProduct()
        {
            //false: add sản phẩm
            //true: update sản phẩm + ID không tăng
            Product product = new Product();
            product.Input(false);
            ProductImpl.ProductList.Add(product);
        }
        public static void ShowAllProduct()
        {
            foreach (Product item in ProductImpl.ProductList)
                //Console.WriteLine(item.ToString());
                item.Output();
        }
        public static Product SearchProduct(string productCode)
        {
            foreach (Product item in ProductList)
            {
                if (productCode.Equals(item.Code))
                    return item;
            }
            return null;
        }
        public static int CountProductInList(List<Product> listProduct)
        {
            int count = 0;
            foreach (Product item in listProduct)
            {
                count++;
            }
            return count;
        }
        public static float SumProductPriceInList(List<Product> listProduct, float discount)
        {
            float sum = 0;
            foreach (Product item in listProduct)
            {
                sum += item.Price;
            }
            sum -= sum * discount;
            return sum;
        }
    }
}

using System.Collections.Generic;
using System;
namespace Assignment
{
    public class ProductsDAO
    {
        static List<Products> listPr;

        public ProductsDAO()
        {
            listPr = new List<Products>();
        }

        public List<Products> ListPr { get => listPr; set => listPr = value; }

        // Add product
        public void addPr(Products sanPham)
        {
            if(sanPham == null)
            {
                System.Console.WriteLine("Tạo product thất bại");
            }
            else
            {
                listPr.Add(sanPham);
            }
        }

        // Xuat danh sach
        public void inDanhSachSP()
        {
            if(listPr != null){
                foreach(Products pr in listPr)
                {
                    System.Console.WriteLine("- {0}",pr.ToString());
                }
            }
            else
            {
                System.Console.WriteLine("Chưa có sản phẩm");
            }
        }
        public static int CountProductInList(List<Products> listProduct)
        {
            int count = 0;
            foreach (Products item in listProduct)
            {
                count++;
            }
            return count;
        }
        public static float SumProductPriceInList(List<Products> listProduct, float discount)
        {
            float sum = 0;
            foreach (Products item in listProduct)
            {
                sum += item.Price;
            }
            sum -= sum * discount;
            return sum;
        }
        public static float ToTalAll(List<Products> listProduct)
        {
            float sum = 0;
            foreach (Products item in listProduct)
            {
                sum += item.Price;
            }
            return sum;
        }
        public static Products SearchProduct(string productCode)
        {
            foreach (Products item in listPr)
            {
                if (productCode.Equals(item.CodePr))
                    return item;
            }
            return null;
        }
    }
}
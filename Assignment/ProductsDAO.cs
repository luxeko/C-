using System.Collections.Generic;
using System;
namespace Assignment
{
    public class ProductsDAO
    {
        List<Products> listPr = new List<Products>();

        public ProductsDAO()
        {
        }

        public ProductsDAO(List<Products> listPr)
        {
            this.listPr = listPr;
        }
        public List<Products> ListPr { get => listPr; set => listPr = value; }

        // Add product
        public void addPr(Products sanPham)
        {
            if(sanPham == null)
            {
                System.Console.WriteLine("Tạo product thất bại");
            }
            else{
                listPr.Add(sanPham);
            }
        }

        public void inDanhSachSP()
        {
            if(listPr != null){
                foreach(Products pr in listPr)
                {
                    System.Console.WriteLine(pr.ToString());
                }
            }
            else
            {
                System.Console.WriteLine("Chưa có sản phẩm");
            }
            
        }
    }
}
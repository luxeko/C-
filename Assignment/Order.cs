using System.Collections.Generic;
using System;
namespace Assignment
{
    public class Order
    {
        private string OrderId;
        private string customerID;
        private DateTime createDate;
        private float amount;
        private int count;
        private float Discount;
        private float tongTien;
        private List<Products> BuyingList;

        public Order()
        {
            BuyingList = new List<Products>();
        }

        public Order(string orderId, string customerID, DateTime createDate, float amount, int count, float discount, float tongTien, List<Products> buyingList)
        {
            OrderId = orderId;
            this.customerID = customerID;
            this.createDate = createDate;
            this.amount = amount;
            this.count = count;
            this.tongTien = tongTien;
            Discount = discount;
            BuyingList = buyingList;
        }

        public string OrderId1 { get => OrderId; set => OrderId = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public float Amount { get => amount; set => amount = value; }
        public int Count { get => count; set => count = value; }
        public float Discount1 { get => Discount; set => Discount = value; }
        public List<Products> BuyingList1 { get => BuyingList; set => BuyingList = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }

        public void input(ProductsDAO listPr)
        {
            OrderId = ChangeTimeToString.ConvertDateTimeToId();
            while (true)
            {
                System.Console.WriteLine("Nhập mã khách hàng: ");
                this.customerID = Console.ReadLine();
                if(!KhachHangDao.ValidateCustomer(this.customerID))
                {
                    break;
                }
                else System.Console.WriteLine("Mã khách hàng không tồn tại");
            }
            this.createDate = DateTime.Now;
            if(KhachHangDao.CheckToDayIsBirthDay(this.customerID, this.createDate))
            {
                this.Discount = 0.1f;
            }
            else this.Discount = 0;
            InputBuyingList(listPr);
            this.count = ProductsDAO.CountProductInList(BuyingList);
            this.Amount = ProductsDAO.SumProductPriceInList(BuyingList, this.Discount);
            this.tongTien = ProductsDAO.ToTalAll(BuyingList);
        }
        public void InputBuyingList(ProductsDAO listPr)
        {
            string inputCode;
            string confirm;
            string[] strInputCode;
            while (true)
            {
                System.Console.WriteLine("Nhập mã product: ");
                inputCode = Console.ReadLine();
                if (!inputCode.Contains(" "))
                {
                    strInputCode = inputCode.Split(new char[] { ',' });
                    for (int i = 0; i < strInputCode.Length; i++)
                    {
                        int prCount = 0;
                        foreach(Products pr in listPr.ListPr)
                        {
                            if(pr.codePr.Equals(strInputCode[i]))
                            {
                                prCount++;
                                this.BuyingList.Add(pr);
                                System.Console.WriteLine("Thêm product mã {0} thành công", strInputCode[i]);
                                // newPr.CountSale++;
                            }
                        }
                        if (prCount == 0)
                            Console.WriteLine("Mã product {0} không tồn tại!", strInputCode[i]);
                    }
                }
                else
                    Console.WriteLine("Lỗi cú pháp. Vui lòng thử lại");
                Console.Write("Bạn có muốn tiếp tục thêm product? (Bấm n : stop): ");
                confirm = Console.ReadLine();

                if(confirm.Equals("n", StringComparison.InvariantCultureIgnoreCase)) break;
            }
        }
        public void Output()
        {
            string sDiscount;
            if (Discount == 0)
                sDiscount = "0%";
            else
                sDiscount = "10%";
            Console.WriteLine("Mã order: {0}, Mã khách hàng: {1}, Ngày tạo: {2}, Số lượng: {3}, Discount: {4}, Số tiền: {5}$, Tổng tiền sau discount: {6}$"
                , OrderId, this.customerID, this.createDate, this.count, sDiscount, this.tongTien, this.amount);
        }

        public void inDachSachSanPhamDaBan(VegesDAO listVg, ComboDAO listCb)
        {
            foreach(Products pr in BuyingList)
            {

               foreach (Vegestable vg in listVg.ListVG)
               {
                   if(vg.codePr.Equals(pr.CodePr))
                   {
                       System.Console.WriteLine("- {0}",vg.ToString());
                   }
               }
               foreach (Combo cb in listCb.ListCombo)
               {
                   if(cb.codePr.Equals(pr.CodePr))
                   {
                       System.Console.WriteLine("- {0}",cb.ToString());
                   }
               }
            }
        }
    }
}
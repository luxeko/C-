using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Order
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreateDate { get; set; }
        public float Amount { get; set; }
        public int Count { get; set; }
        public float Discount { get; set; }
        public List<Product> BuyingList { get; set; }
        public Order()
        {
            BuyingList = new List<Product>();
        }
        public void Input()
        {
            OrderId = Method.ConvertDateTimeToId();
            while (true)
            {
                Console.WriteLine("Input customer ID: ");
                CustomerId = Console.ReadLine();
                if (!CustomerImpl.ValidateCustomer(CustomerId))
                    break;
                else
                    Console.WriteLine("Invalid customer ID");
            }
            CreateDate = DateTime.Now;
            if (CustomerImpl.CheckToDayIsBirthDay(CustomerId, CreateDate))
                Discount = 0.1f;
            else
                Discount = 0;
            InputBuyingList();
            Count = ProductImpl.CountProductInList(BuyingList);
            Amount = ProductImpl.SumProductPriceInList(BuyingList, Discount);
        }
        public void InputBuyingList()
        {
            string inputCode;
            string confirm;
            string[] strInputCode;
            while (true)
            {
                Console.WriteLine("--------------------VEGESTABLE LIST--------------------");
                VegestableImpl.ShowAllVegestable(VegestableImpl.VegestableList);
                Console.WriteLine("----------------------COMBO LIST-----------------------");
                ComboImpl.ShowAllCombo(ComboImpl.ComboList);
                Console.WriteLine("Enter code product to add, comma separated and do not contains spaces (e.g: 1000,1001,1002): ");
                inputCode = Console.ReadLine();
                if (!inputCode.Contains(" "))
                {
                    strInputCode = inputCode.Split(',');
                    for (int i = 0; i < strInputCode.Length; i++)
                    {
                        if (!ProductImpl.ValidateCode(strInputCode[i], -1))
                        {
                            Product newProduct = ProductImpl.SearchProduct(strInputCode[i]);
                            BuyingList.Add(newProduct);
                            //
                            newProduct.CountSale++;
                        }
                        else
                            Console.WriteLine("Product with code {0} doesn't exits", strInputCode[i]);
                    }
                }
                else
                    Console.WriteLine("Product lists must not have spaces and are separated by commas (e.g: 1000,1001,1002)");
                Console.Write("Add more product to order list? (stop = n): ");
                confirm = Console.ReadLine();
                if (confirm.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    break;
            }
        }
        public void Output()
        {
            string sDiscount;
            if (Discount == 0)
                sDiscount = "0%";
            else
                sDiscount = "10%";
            Console.WriteLine("OrderID: {0} CustomerID: {1} CreateDate: {2} Count: {3} Discount: {4} Amount: {5}"
                , OrderId, CustomerId, CreateDate, Count, sDiscount, Amount);
        }
    }
}

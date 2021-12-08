using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class OrderImpl
    {
        public static List<Order> OrderList { get; set; }
        public static void ShowAllOrderList(List<Order> orderList)
        {
            foreach (Order item in orderList)
                item.Output();
        }
        public static void CreateOrder()
        {
            Order order = new Order();
            order.Input();
            OrderList.Add(order);
        }
        public static float TotalSale(List<Order> orderList)
        {
            float totalSale = 0;
            foreach (Order item in orderList)
                totalSale += item.Amount;
            return totalSale;
        }
        public static int TotalProductSold(List<Order> orderList)
        {
            int totalProductSold = 0;
            foreach (Order item in orderList)
                totalProductSold += item.Count;
            return totalProductSold;
        }
    }
}

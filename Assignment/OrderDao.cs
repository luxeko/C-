using System.Collections.Generic;
namespace Assignment
{
    internal static class OrderDao
    {
        private static List<Order> listOrder;

        public static List<Order> ListOrder { get => listOrder; set => listOrder = value; }
        public static void ShowAllOrderList(List<Order> orderList)
        {
            foreach (Order item in orderList)
            {
                item.Output();
            }
                
        }
        public static void CreateOrder(ProductsDAO listPr)
        {
            Order order = new Order();
            order.input(listPr);
            listOrder.Add(order);
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
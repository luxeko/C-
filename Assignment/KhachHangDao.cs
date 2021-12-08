using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class KhachHangDao
    {
        /*
        true: code hợp lệ (không trùng) 
        false: code không hợp lệ (trùng) 
         */
        private static List<KhachHang> listCustomer;

        public static List<KhachHang> ListCustomer { get => listCustomer; set => listCustomer = value; }
        public static bool ValidateCustomer(string customerID)
        {
            foreach(KhachHang kh in listCustomer)
            {
                if(customerID.Equals(kh.CustomerID))
                {
                    return false;
                }
            }
            return true;
        }

        public static void AddCustomerByInfor(string code, string name, string date)
        {
            listCustomer.Add(new KhachHang() {CustomerID = code, CustomerName = name, CustomerBirthDay = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture)});
        }

        public static void ShowAllCustomer(List<KhachHang> customerList)
        {
            foreach (KhachHang kh in listCustomer)
            {
                kh.output();
            }
        }

        public static bool CheckToDayIsBirthDay(string customerCode, DateTime datetime)
        {
            KhachHang kh = SearchCustomer(customerCode);
            if(kh.CustomerBirthDay.Day == datetime.Day && kh.CustomerBirthDay.Month == datetime.Month)
            {
                return true;
            }
            return false;
        }

        public static KhachHang SearchCustomer(string customerCode)
        {
            foreach (KhachHang kh in listCustomer)
            {
                if (customerCode.Equals(kh.CustomerID))
                    return kh;
            }
            return null;
        }
    }
}
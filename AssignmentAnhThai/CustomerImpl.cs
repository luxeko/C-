using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class CustomerImpl
    {
        /*
        true: code hợp lệ (không trùng) 
        false: code không hợp lệ (trùng) 
         */
        public static List<Customer> CustomerList { get; set; }
        public static bool ValidateCustomer(string customerId)
        {
            foreach (Customer item in CustomerList)
            {
                if (customerId.Equals(item.CustomerId))
                    return false;
            }
            return true;
        }
        public static void AddCustomerByInfo(string code, string name, string date)
        {
            CustomerList.Add(new Customer() { CustomerId = code, CustomerName = name, DateOfBirth = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture) });
        }
        public static void ShowAllCustomer(List<Customer> customerList)
        {
            foreach (Customer item in customerList)
                item.Output();
        }
        public static bool CheckToDayIsBirthDay(string customerCode, DateTime dateTime)
        {
            Customer customer = SearchCustomer(customerCode);
            if (customer.DateOfBirth.Day == dateTime.Day && customer.DateOfBirth.Month == dateTime.Month)
                return true;
            return false;
        }
        public static Customer SearchCustomer(string customerCode)
        {
            foreach (Customer item in CustomerList)
            {
                if (customerCode.Equals(item.CustomerId))
                    return item;
            }
            return null;
        }
    }
}

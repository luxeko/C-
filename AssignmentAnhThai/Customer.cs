using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public void Input()
        {
            while (true)
            {
                Console.Write("Input customer ID: ");
                CustomerId = Console.ReadLine();
                bool result = CustomerImpl.ValidateCustomer(CustomerId);
                if (CustomerId.Length == 4 && !CustomerId.Contains(" "))
                {
                    if (result)
                        break;
                    else
                        Console.WriteLine("Code already exists");
                }
                else
                    Console.WriteLine("Code must have 4 characters and doesn't contain spaces");
            }
            while (true)
            {
                Console.Write("Input customer Name: ");
                CustomerName = Console.ReadLine();
                if (CustomerName != null)
                    break;
                else
                    Console.WriteLine("Name can't be null");
            }
            while (true)
            {
                Console.Write("Date of birth (dd/mm/yyyy): ");
                try
                {
                    DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Date format must be \"dd/mm/yyyy\"");
                }
            }
        }
        public void Output()
        {
            string sDateOfBirth = String.Format("{0:dd/MM/yyyy}", DateOfBirth);
            Console.WriteLine("CustomerID: {0,-5} Name: {1, -8} Date of birth: {2, -10}", CustomerId, CustomerName, sDateOfBirth);
        }
    }
}

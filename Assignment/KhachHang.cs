using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class KhachHang
    {
        private string customerID;
        private string customerName;
        private DateTime customerBirthDay;

        public KhachHang()
        {
        }

        public KhachHang(string customerID, string customerName, DateTime customerBirthDay)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerBirthDay = customerBirthDay;
        }

        public string CustomerID { get => customerID; set => customerID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public DateTime CustomerBirthDay { get => customerBirthDay; set => customerBirthDay = value; }

        public void intput()
        {
            while (true)
            {
                System.Console.WriteLine("Nhập mã khách hàng: ");
                this.customerID = Console.ReadLine();
                bool result = KhachHangDao.ValidateCustomer(this.customerID);
                if(this.customerID.Length == 4 && !this.customerID.Trim().Equals(""))
                {
                    if(result) break;
                    else System.Console.WriteLine("Mã khách hàng đã tồn tại");
                }
                else System.Console.WriteLine("Mã khách hàng phải có 4 ký tự");
            }
            while (true)
            {
                System.Console.WriteLine("Nhập tên khách hàng: ");
                this.customerName = Console.ReadLine();
                if(this.customerName.Trim().Equals(""))
                {
                    System.Console.WriteLine("Tên khách hàng không được để trống");
                }
                else break;
            }
            while (true)
            {
                System.Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy): ");
                try
                {
                    this.customerBirthDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Thời gian phải theo form \"dd/MM/yyyy\"");
                }
            }
        }
        public void output()
        {
            string sDateOfBirth = string.Format("{0:dd/MM/yyyy}", CustomerBirthDay);
            System.Console.WriteLine("Mã khách hàng: {0,-6} Tên KH: {1,-10} Ngày sinh: {2, -10}", this.customerID, this.customerName, sDateOfBirth);
        }

        
    }
}
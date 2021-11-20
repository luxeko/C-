using System.Globalization;
using System;

namespace Buoi4
{
    /*
        Class thông thường - non-static: chứa thành phần thuộc instance và thành phần tĩnh - static
    */
    /*
        * Phạm vi truy cập: namespace, class , interface, enum, structs..., biến và hàm của lớp
        public: không hạn chế truy cập
        private: truy cập trong phạm vi của lớp định nghĩa
        protected: truy cập trong phạ, vi của lớp địn nghĩa và các lớp con
        internal: truy cập trong các phạm vi của 1 project/ assembly (mặc định đối với namespace, class, interface, enum, structs)
    */
    class Book
    {
        // biến
        /*
            - biến locoal: biến khai báo và sử dụng trong phạm vi của hàm, muốn dùng phải bắt buộc gán giá trị, thời gian sống cùng với thời gian sống của hàm
            - biến instance: thể hiện đặc điểm, tính chất của từng đối tượng/ instance/ entity. -> thời gian sống cùng với thời gian sống của đối tượng
            - biến tĩnh/static: biến dùng chung cho mọi đối tượng của lớp -> dùng thông qua lớp, (không phải đối tượng)
        */

        /*
            biến: fields, properties
            - fields: các biến private cần dc che dấu và không nên dc truy cập trực tiếp của đối tượng -> private
            - properties: các biến non-private, tương ứng cách thức truy cập với các biến private của đối tượng
        */

        string name;//private
        // hàm - phương thức: instance/ static

        public string getName() {
            return this.name;
        }

        public void setName(string name1) {
            this.name = name1;
        }

        //property: 1 biến non-private đại diện cho 1 biến private trong đối tượng
        //property Name đại diện cho biến private của book
        internal string Name
        {
            //get: trả về giá trị của 1 field tương ứng
            get
            {
                return this.name;
            }
            //set: gán giá trị value cho field tương ứng
            set
            {
                this.name = value;
            }
        }

        // public int Price{ get => Price; set => value; }
        public int Price { 
            get
            {
                int price2 = price/1000;
                return price2;
            }
            set => price = value;
        }

        public string Author { get => author; private set => author = value; }
        // chỉ đọc/ ko dc ghi/ gán
        public DateTime Publish { get => publish; private set => publish = value; }

        private int price;
        private string author;
        private DateTime publish;

        internal const string className = "Book - Sách";
        public static string cate = "Paper Book";

        
        /*
            - hàm khởi tạo
            - hàm huỷ
            - hàm nghiệp vụ -> hành vi của các đối tượng
        */
        // Hàm - phương thức: instance / static
        // - Hàm khởi tạo: khởi tạo đối tượng + khởi tạo giá trị cho các biến của instance, có thể tạo ra nhiều hàm constructor

        // this: nằm trong phạm vi hàm non-static của lớp
        // this: đại diện cho đối tượng hiện tại đang thực hiện runtime, phân biệt giữa biến instance và tham số của hàm
        // this: tham chiếu tới thành phần của instance đó (biến, hàm)
        public Book()
        {
            
        }
        public Book(string name, int price, string author, DateTime publish)
        {
            this.name = name;
            this.price = price;
            this.author = author;
            this.publish = publish;
        }

        public Book getInstance()
        {
            return this;
        }

        // hàm huỷ: hành vi trước khi đối tượng bị thu hồi trong bộ nhớ 
        // C# chỉ có duy nhất 1 hàm destructor ko có tham số
        ~Book()
        {
            System.Console.WriteLine("Toi sap bi thu hoi");
        }
        
        // hàm nghiệp vụ
        public void input()
        {
            System.Console.WriteLine("Name: ");
            this.name = Console.ReadLine();
            System.Console.WriteLine("Price: ");
            this.price = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Author: ");
            this.author = Console.ReadLine();
            System.Console.WriteLine("Publish date: ");
            this.publish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
        public void output(out string param)
        // public void output(ref string param)
        {
            param = this.name + ", " + this.author + ", " + this.price + ", " + this.publish;
            System.Console.WriteLine("Name: {0}, Price: {1}, Author: {2}, Publish: {3}", this.name, this.price, this.author, this.publish);
        }

    }

        

    /*
        Class tĩnh - static: chứa các thành phần tĩnh - static (biến tĩnh và hàm tĩnh) -> dùng chung
        - Không cho phép kế thừa và tạo đối tượng/instance
    */
    
    static class BookInfo
    {

    }
}

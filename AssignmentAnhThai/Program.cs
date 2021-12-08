using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        /*
        ID không được set khi update
        date create không set
        trùng ID vẫn được update


         */
        static void Main(string[] args)
        {
            ProductImpl.ProductList = new List<Product>();
            VegestableImpl.VegestableList = new List<Vegestable>();
            ComboImpl.ComboList = new List<Combo>();
            CustomerImpl.CustomerList = new List<Customer>();
            OrderImpl.OrderList = new List<Order>();
            AddDataBase();
            SubCaseMenu6_1();
            string choose = "";
            while (true)
            {
                Console.WriteLine("--------------------VEGESTABLE STORE--------------------");
                Console.WriteLine("1. CRUD VEGESTABLE");
                Console.WriteLine("2. CRUD COMBO");
                Console.WriteLine("3. ALL PRODUCT");
                Console.WriteLine("4. CRUD ORDER");
                Console.WriteLine("5. REPORT");
                Console.WriteLine("6. CUSTOMER");
                Console.WriteLine("0. Exit program");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        CaseMenu1();
                        break;
                    case "2":
                        CaseMenu2();
                        break;
                    case "3":
                        CaseMenu3();
                        break;
                    case "4":
                        CaseMenu4();
                        break;
                    case "5":
                        CaseMenu5();
                        break;
                    case "6":
                        CaseMenu6();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
            }
        }
        public static void CaseMenu1()
        {   
            //Console.WriteLine("1. CRUD VEGESTABLE");
            while (true)
            {
                string choose = "";
                bool flag = true;
                Console.WriteLine("1. ADD 1 VEGESTABLE");
                Console.WriteLine("2. DISPLAY ALL VEGESTABLE LIST");
                Console.WriteLine("3. SEARCH VEGESTABLE BY CODE");
                Console.WriteLine("4. UPDATE VEGESTABLE BY CODE");
                Console.WriteLine("0. EXIT CRUD VEGESTABLE");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        SubCaseMenu1_1();
                        break;
                    case "2":
                        SubCaseMenu1_2();
                        break;
                    case "3":
                        SubCaseMenu1_3();
                        break;
                    case "4":
                        SubCaseMenu1_4();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
                if (flag == false)
                    break;
            }
        }
        public static void SubCaseMenu1_1()
        {
            //Console.WriteLine("1. ADD 1 VEGESTABLE");
            string confirm = "";
            while (true)
            {
                Vegestable vegestable = new Vegestable();
                bool result = VegestableImpl.AddVegestable(vegestable);
                if (result)
                    Console.WriteLine("Add vegestable successed");
                Console.Write("Continue add vegestable? (stop = n): ");
                confirm = Console.ReadLine();
                if (confirm.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    break;
            }
        }
        public static void SubCaseMenu1_2()
        {
            //Console.WriteLine("2. DISPLAY ALL VEGESTABLE LIST");
            VegestableImpl.ShowAllVegestable(VegestableImpl.VegestableList);
  
        }
        public static void SubCaseMenu1_3()
        {
            //Console.WriteLine("3. SEARCH VEGESTABLE BY CODE");
            string code;
            Vegestable vegestable = new Vegestable();
            Console.Write("Enter vegestable code to search: ");
            code = Console.ReadLine();
            if (code == null)
                Console.WriteLine("Invalid code");
            else
            {
                vegestable = VegestableImpl.SearchVegestableByCode(code);
                if (vegestable == null)
                    Console.WriteLine("Vegestable not found");
                else
                {
                    Console.WriteLine("Vegestable found: " + vegestable.ToString());
                }    
            }    
        }
        public static void SubCaseMenu1_4()
        {
            //Console.WriteLine("4. SEARCH VEGESTABLE BY CODE");
            bool result = VegestableImpl.UpdateVegestableByCode();
            if (result)
                Console.WriteLine("Update successed");
            else
                Console.WriteLine("Invalid code");
        }
        public static void CaseMenu2()
        {
            //Console.WriteLine("2. CRUD COMBO");
            while (true)
            {
                string choose = "";
                bool flag = true;
                Console.WriteLine("1. ADD 1 COMBO AND ADD LIST VEGESTABLE TO COMBO");
                Console.WriteLine("2. DISPLAY ALL COMBO AND LIST VEGESTABLE IN EACH COMBO");
                Console.WriteLine("3. DISPLAY ALL COMBOS CONTAINING INPUT VEGETABLE");
                Console.WriteLine("4. ADD 1 OR MORE VEGESTABLE TO COMBO");
                Console.WriteLine("0. EXIT CRUD COMBO");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        SubCaseMenu2_1();
                        break;
                    case "2":
                        SubCaseMenu2_2();
                        break;
                    case "3":
                        SubCaseMenu2_3();
                        break;
                    case "4":
                        SubCaseMenu2_4();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
                if (flag == false)
                    break;
            }
        }
        public static void SubCaseMenu2_1()
        {
            //Console.WriteLine("1. ADD 1 COMBO AND ADD LIST VEGESTABLE TO COMBO");
            string confirm = "";
            while (true)
            {
                ComboImpl.AddCombo();
                Console.Write("Continue create combo? (stop = n): ");
                confirm = Console.ReadLine();
                if (confirm.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                    break;
            }
        }
        public static void SubCaseMenu2_2()
        {
            //Console.WriteLine("2. DISPLAY ALL COMBO AND LIST VEGESTABLE IN EACH COMBO");
            ComboImpl.ShowAllCombo(ComboImpl.ComboList);
        }
        public static void SubCaseMenu2_3()
        {
            //Console.WriteLine("3. DISPLAY ALL COMBOS CONTAINING INPUT VEGETABLE");
            string inputVegesCode;
            Console.Write("Enter vegestable code: ");
            inputVegesCode = Console.ReadLine();
            if (ComboImpl.IsCombo(inputVegesCode))
                Console.WriteLine("{0} is combo code, not a vegestable code", inputVegesCode);
            else
            {
                List<Combo> result = ComboImpl.ComboContainVeges(inputVegesCode);
                Console.WriteLine("Combos contain vegestable code {0}: ", inputVegesCode);
                if (result != null)
                {
                    ComboImpl.ShowAllCombo(result);  
                }    
                else
                    Console.WriteLine("Not found combos contain vegestable code {0}", inputVegesCode);
            }    
        }
        public static void SubCaseMenu2_4()
        {
            //Console.WriteLine("4. ADD 1 OR MORE VEGESTABLE TO COMBO");
            string comboCode;
            Console.WriteLine("Exist combo: ");
            ComboImpl.ShowAllComboId();
            Console.Write("Enter combo ID to add vegestable: ");
            comboCode = Console.ReadLine();
            Combo combo = ComboImpl.SearchCombo(comboCode);
            if (combo != null)
            {
                combo.AddVegesToCombo();
            }    
            else
                Console.WriteLine("Combo doesn't exits");


        }
        public static void CaseMenu3()
        {
            //Console.WriteLine("3. ALL PRODUCT");
            while (true)
            {
                string choose = "";
                bool flag = true;
                Console.WriteLine("1. DISPLAY ALL PRODUCT LIST");
                Console.WriteLine("2. SEARCH VEGESTABLE OR COMBO BY ID");
                Console.WriteLine("0. EXIT ALL PRODUCT");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        SubCaseMenu3_1();
                        break;
                    case "2":
                        SubCaseMenu3_2();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
                if (flag == false)
                    break;
            }
        }
        public static void SubCaseMenu3_1()
        {
            //Console.WriteLine("1. DISPLAY ALL PRODUCT LIST");
            //ProductImpl.ShowAllProduct();
            Console.WriteLine("--------------------VEGESTABLE LIST--------------------");
            VegestableImpl.ShowAllVegestable(VegestableImpl.VegestableList);
            Console.WriteLine("----------------------COMBO LIST-----------------------");
            ComboImpl.ShowAllCombo(ComboImpl.ComboList);
        }
        public static void SubCaseMenu3_2()
        {
            //Console.WriteLine("2. SEARCH VEGESTABLE OR COMBO BY ID");
            string inputCode;
            Console.Write("Enter product code to search: ");
            inputCode = Console.ReadLine();
            Product product = ProductImpl.SearchProduct(inputCode);
            if (product != null)
                product.Output();
            else
                Console.WriteLine("Product not found");
        }
        public static void CaseMenu4()
        {
            //Console.WriteLine("4. CRUD ORDER");
            while (true)
            {
                string choose = "";
                bool flag = true;
                Console.WriteLine("1. CREATE NEW ORDER");
                Console.WriteLine("2. DISPLAY ALL ORDER");
                Console.WriteLine("0. EXIT CRUD ORDER");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        SubCaseMenu4_1();
                        break;
                    case "2":
                        SubCaseMenu4_2();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
                if (flag == false)
                    break;
            }
        }
        public static void SubCaseMenu4_1()
        {
            //Console.WriteLine("1. CREATE NEW ORDER");
            OrderImpl.CreateOrder();
        }
        public static void SubCaseMenu4_2()
        {
            //Console.WriteLine("2. DISPLAY ALL ORDER");
            OrderImpl.ShowAllOrderList(OrderImpl.OrderList);
        }
        public static void CaseMenu5()
        {
            //Console.WriteLine("5. REPORT");
            while (true)
            {
                string choose = "";
                bool flag = true;
                Console.WriteLine("1. DISPLAY TOTAL QUANTITY AND TOTAL SALES");
                Console.WriteLine("2. DISPLAYS A LIST OF PRODUCTS SOLD DURING THE PERIOD");
                Console.WriteLine("0. EXIT REPORT");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        SubCaseMenu5_1();
                        break;
                    case "2":
                        SubCaseMenu5_2();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
                if (flag == false)
                    break;
            }
        }
        public static void SubCaseMenu5_1()
        {
            //Console.WriteLine("1. DISPLAY TOTAL QUANTITY AND TOTAL SALES");
            int totalProductSold = OrderImpl.TotalProductSold(OrderImpl.OrderList);
            float totalSale = OrderImpl.TotalSale(OrderImpl.OrderList);
            Console.WriteLine("TOTAL PRODUCT SOLD: {0,-5} TOTAL SALE: {1,-10}", totalProductSold, totalSale);
        }
        public static void SubCaseMenu5_2()
        {
            //Console.WriteLine("2. DISPLAYS A LIST OF PRODUCTS SOLD DURING THE PERIOD");

        }
        public static void CaseMenu6()
        {
            while (true)
            {
                string choose = "";
                bool flag = true;
                Console.WriteLine("1. ADD CUSTOMER LIST FROM FILE");
                Console.WriteLine("2. SHOW CUSTOMER LIST");
                Console.WriteLine("0. EXIT CUSTOMER");
                Console.Write("Enter your choice: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        SubCaseMenu6_1();
                        break;
                    case "2":
                        SubCaseMenu6_2();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice doesn't exist");
                        break;
                }
                if (flag == false)
                    break;
            }
        }
        public static void SubCaseMenu6_1()
        {
            //Console.WriteLine("1. ADD CUSTOMER LIST FROM FILE");
            try
            {
                //b1: tạo stream kết nối nguồn dữ liệu
                using (StreamReader sr = new StreamReader("D:\\Download\\CustomerAssignment.txt", System.Text.Encoding.UTF8))
                {
                    //b2: thực thi
                    string line = "";
                    DateTime date1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] part = new string[3];
                        part = line.Split(',');
                        if (part.Length != 3)
                            Console.WriteLine(line + "=> Line không hợp lệ");
                        else
                        {
                            //Console.WriteLine(line);
                            if (part[0].Length != 4 && part[0].Contains(" "))
                                Console.Write("ID must be 4 characters and contain no spaces");
                            if ((part[1]) == null)
                                Console.Write("Name can't be null");
                            if (!DateTime.TryParse(part[2], out date1))
                                Console.Write(part[2] + " must be DateTime format\n");
                            if (part[0].Length == 4 && !part[0].Contains(" ") 
                                && (part[1]) != null && DateTime.TryParse(part[2], out date1))
                            {
                                if (CustomerImpl.ValidateCustomer(part[0]))
                                {
                                    CustomerImpl.AddCustomerByInfo(part[0], part[1], part[2]);
                                    Console.WriteLine("Add customer successed");
                                }    
                                else
                                    Console.WriteLine("Customer ID already exist");
                            }
                            else
                                Console.WriteLine("Wrong input format - Add customer failed");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public static void SubCaseMenu6_2()
        {
            //Console.WriteLine("2. SHOW CUSTOMER LIST");
            CustomerImpl.ShowAllCustomer(CustomerImpl.CustomerList);
            Order order = new Order();
            order.Input();
        }
        public static void AddDataBase()
        {
            Vegestable vegestable = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 80,
                Code = "1100",
                Name = "raumuong",
                Price = 10,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable1 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 81,
                Code = "1101",
                Name = "rauday",
                Price = 11,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable2 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 82,
                Code = "1102",
                Name = "mongtoi",
                Price = 12,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable3 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 83,
                Code = "1103",
                Name = "raulang",
                Price = 10,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable4 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 84,
                Code = "1104",
                Name = "raungot",
                Price = 13,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable5 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 85,
                Code = "1105",
                Name = "caicuc",
                Price = 12,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable6 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 86,
                Code = "1106",
                Name = "raumui",
                Price = 8,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable7 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 87,
                Code = "1107",
                Name = "raubi",
                Price = 9,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable8 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 88,
                Code = "1108",
                Name = "xalach",
                Price = 15,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Vegestable vegestable9 = new Vegestable();
            VegestableImpl.VegestableList.Add(vegestable = new Vegestable
            {
                Id = 89,
                Code = "1109",
                Name = "xalach",
                Price = 15,
                Category = "rau",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
            ProductImpl.ProductList.Add(vegestable);
            Combo combo1 = new Combo();
            ComboImpl.ComboList.Add(combo1 = new Combo
            {
                Id = 90,
                Code = "1110",
                Name = "combo1",
                Price = 22,
                Status = 1,
                ListVegesCombo = new List<Vegestable>(),
            });
            ProductImpl.ProductList.Add(combo1);
            Combo combo2 = new Combo();
            ComboImpl.ComboList.Add(combo1 = new Combo
            {
                Id = 91,
                Code = "1111",
                Name = "combo2",
                Price = 25,
                Status = 1,
                ListVegesCombo = new List<Vegestable>(),
            });
            ProductImpl.ProductList.Add(combo1);
            Combo combo3 = new Combo();
            ComboImpl.ComboList.Add(combo1 = new Combo
            {
                Id = 92,
                Code = "1112",
                Name = "combo3",
                Price = 30,
                Status = 1,
                ListVegesCombo = new List<Vegestable>(),
            });
            ProductImpl.ProductList.Add(combo1);
            Combo combo4 = new Combo();
            ComboImpl.ComboList.Add(combo1 = new Combo
            {
                Id = 93,
                Code = "1113",
                Name = "combo4",
                Price = 34,
                Status = 1,
                ListVegesCombo = new List<Vegestable>(),
            });
            ProductImpl.ProductList.Add(combo1);
            Combo combo5 = new Combo();
            ComboImpl.ComboList.Add(combo1 = new Combo
            {
                Id = 94,
                Code = "1114",
                Name = "combo5",
                Price = 41,
                Status = 1,
                ListVegesCombo = new List<Vegestable>(),
            });
            ProductImpl.ProductList.Add(combo1);
        }
    }
}

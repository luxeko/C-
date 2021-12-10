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
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int check;
            bool flag = true;
            ProductsDAO listPr = new ProductsDAO();
            VegesDAO listVg = new VegesDAO();
            ComboDAO listCb = new ComboDAO();
            OrderDao.ListOrder = new List<Order>();
            KhachHangDao.ListCustomer = new List<KhachHang>();
            SubMenuCustomer_1();
            AddDataBase(listVg, listPr);
            do
            { 
                showMenu();
                check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        int choose;
                        bool flagVG = true;
                        do
                        {
                            System.Console.WriteLine("--- CRUD Vegestable ---");
                            System.Console.WriteLine("1. Thêm 1 vegestable");
                            System.Console.WriteLine("2. Hiển thị danh sách vegestable");
                            System.Console.WriteLine("3. Tìm kiếm vegestable qua mã: ");
                            System.Console.WriteLine("4. Cập nhật thông tin");
                            System.Console.WriteLine("5. Thoát");
                            System.Console.WriteLine("Choose: ");
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    string confirm ="";
                                    do
                                    {
                                        Vegestable vg = new Vegestable();
                                        vg.input(listPr);
                                        listVg.addVeg(vg, listPr);
                                        System.Console.WriteLine("Tiếp tục tạo vegestable? (Bấm n : stop)");
                                        confirm = Console.ReadLine();
                                    } while (!confirm.Equals("n"));
                                    break;
                                case 2:
                                    listVg.inDanhSachVG();
                                    break;
                                case 3:
                                    listVg.searchVg();
                                    break;
                                case 4:
                                    listVg.updateVg();
                                    break;
                                case 5:
                                    System.Console.WriteLine("Thoát!");
                                    break;
                                default:
                                    System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                                    break;
                            }
                            if(choose == 5) flagVG = false;
                        } while (flagVG == true);
                        break;
                    case 2:
                        int chooseCB;
                        bool flagCB = true;
                        do
                        {
                            System.Console.WriteLine("--- CRUD Combo ---");
                            System.Console.WriteLine("1. Thêm 1 combo");
                            System.Console.WriteLine("2. Hiển thị danh sách combo và vegestable theo combo");
                            System.Console.WriteLine("3. Tìm kiếm combo qua mã");
                            System.Console.WriteLine("4. Thêm 1/nhiều vegestable vào 1 combo (theo mã combo)");
                            System.Console.WriteLine("5. Thoát");
                            System.Console.WriteLine("Choose: ");
                            chooseCB = Convert.ToInt32(Console.ReadLine());
                            switch (chooseCB)
                            {
                                case 1:
                                    string confirm = "";
                                    do
                                    {
                                        Combo cb = new Combo();
                                        cb.input(listPr);
                                        listCb.newCombo(cb, listPr, listVg);
                                        System.Console.WriteLine("Tiếp tục tạo combo? (Bấm n: stop)");
                                        confirm = Console.ReadLine();
                                    } while (!confirm.Equals("n"));
                                    break;
                                case 2:
                                    listCb.inCombo();
                                    break;
                                case 3:
                                    listCb.searchCombo();
                                    break;
                                case 4:
                                    string confirm4 = "";
                                    do
                                    {
                                        listVg.inCodeVegestable();
                                        listCb.inCodeCombo();
                                        listCb.AddVegInCombo(listVg, listPr);
                                        System.Console.WriteLine("Tiếp tục thêm vegestable vào combo? (Bấm n: stop)");
                                        confirm4 = Console.ReadLine();
                                    } while (!confirm4.Equals("n"));
                                    
                                    break;
                                case 5:
                                    System.Console.WriteLine("Thoát!");
                                    break;
                                default:
                                    System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                                    break;
                            }
                            if(chooseCB == 5) flagCB = false;
                        } while (flagCB == true);
                        break;
                    case 3:
                        int choosePr;
                        bool flagPr = true;
                        do
                        {
                            System.Console.WriteLine("--- ALL Products ---");
                            System.Console.WriteLine("1. Hiển thị toàn bộ Products");
                            System.Console.WriteLine("2. Tìm kiếm products theo mã");
                            System.Console.WriteLine("3. Thoát");
                            System.Console.WriteLine("Choose: ");
                            choosePr = Convert.ToInt32(Console.ReadLine());
                            switch (choosePr)
                            {
                                case 1:
                                    System.Console.WriteLine("***** List products *****");
                                    listPr.inDanhSachSP();
                                    System.Console.WriteLine("***** List vegestable *****");
                                    listVg.inDanhSachVG();
                                    System.Console.WriteLine("***** List combo *****");
                                    listCb.inCombo();
                                    break;
                                case 2:            
                                    string maTimKiem;
                                    string confirm = "";
                                    do
                                    {
                                        System.Console.WriteLine("Nhập mã tìm kiếm: ");
                                        int count = 0;
                                        maTimKiem = Console.ReadLine();
                                        foreach(Products pr in listPr.ListPr)
                                        {
                                            if(maTimKiem.Equals(pr.CodePr))
                                            {
                                                count++;
                                                foreach(Vegestable vg in listVg.ListVG)
                                                {
                                                    if(maTimKiem.Equals(vg.CodePr))
                                                    {
                                                        System.Console.WriteLine("- {0}",vg.ToString());
                                                    }
                                                }
                                                foreach(Combo cb in listCb.ListCombo)
                                                {
                                                    if(maTimKiem.Equals(cb.CodePr))
                                                    {
                                                        System.Console.WriteLine("- {0}",cb.ToString());
                                                        foreach (Vegestable vg in cb.Vegestables)
                                                        {
                                                            System.Console.WriteLine(string.Format("   + {0}",vg.ToString()));
                                                        }
                                                    }
                                                }                      
                                            }
                                        }
                                        if(count == 0) System.Console.WriteLine("Mã combo sai hoặc không tồn tại");
                                        System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                                        confirm = Console.ReadLine(); 
                                    } while (!confirm.Equals("n"));
                                    break;
                                case 3:
                                    System.Console.WriteLine("Thoát!");
                                    break;
                                default:
                                    System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                                    break;
                            }
                            if(choosePr == 3) flagPr = false;
                        } while (flagPr == true);

                        break;
                    case 4:
                        int chooseOrder;
                        bool flagOrder = true;
                        do
                        {
                            System.Console.WriteLine("--- CRUD Đơn hàng ---");
                            System.Console.WriteLine("1. Tạo đơn hàng mới");
                            System.Console.WriteLine("2. Hiển thị danh sách đơn hàng");
                            System.Console.WriteLine("3. Thoát");
                            System.Console.WriteLine("Choose: ");
                            chooseOrder = Convert.ToInt32(Console.ReadLine());
                            switch (chooseOrder)
                            {
                                case 1:
                                    listVg.inCodeVegestable();
                                    listCb.inCodeCombo();
                                    string confirm;
                                    do
                                    {
                                        OrderDao.CreateOrder(listPr);
                                        System.Console.WriteLine("Bạn có muốn tiếp tục tạo đơn hàng? (Bấm n : stop)");
                                        confirm = Console.ReadLine();
                                    } while (!confirm.Equals("n"));
                                    
                                    break;
                                case 2:
                                    OrderDao.ShowAllOrderList(OrderDao.ListOrder);
                                    break;
                                case 3:
                                    System.Console.WriteLine("Thoát!");
                                    break;
                                default:
                                    System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                                    break;
                            }
                            if(chooseOrder == 3) flagOrder = false;
                        } while (flagOrder == true);
                        break;
                    case 5:
                        CaseMenuReport(OrderDao.ListOrder, listVg, listCb);
                        break;
                    case 6:
                        CaseMenuCustomer(listPr);
                        break;
                    case 7:
                        System.Console.WriteLine("Thank you!");
                        break;
                    default:
                        System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                        break;
                }
                if(check == 7) flag = false;
            } while (flag == true);
        }
        static void showMenu()
        {
            System.Console.WriteLine("---- Quan ly don hang san pham ----");
            System.Console.WriteLine("1. CRUD Vegestable");
            System.Console.WriteLine("2. CRUD Combo");
            System.Console.WriteLine("3. ALL Products");
            System.Console.WriteLine("4. CRUD Đơn hàng");
            System.Console.WriteLine("5. Báo cáo");
            System.Console.WriteLine("6. Khách hàng");
            System.Console.WriteLine("7. Exit!");
            System.Console.WriteLine("Choose: ");
        }

        static void CaseMenuReport(List<Order> orderList, VegesDAO listVg, ComboDAO listCb)
        {
            int choose;
            bool flag = true;
            do
            {
                System.Console.WriteLine("--- Báo cáo ---");
                System.Console.WriteLine("1. Hiển thị số lượng và tổng sản phẩm bán hàng");
                System.Console.WriteLine("2. Hiển thị danh sách sản phẩm bán trong khoảng thời gian");
                System.Console.WriteLine("3. Thoát!");
                System.Console.WriteLine("Choose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {   
                    case 1:
                        SubMenuReport_1(orderList, listVg, listCb);
                        break;
                    case 2:
                        break;
                    case 3:
                        System.Console.WriteLine("Thoát!");
                        break;
                    default:
                        System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                        break;
                }
                
                if(choose == 3) flag = false;
            } while (flag == true);
        }
        static void SubMenuReport_1(List<Order> orderList, VegesDAO listVg, ComboDAO listCb)
        {
            int totalAllProductSold = OrderDao.TotalProductSold(OrderDao.ListOrder);
            float totalMoney = OrderDao.TotalSale(OrderDao.ListOrder);
            System.Console.WriteLine("Tổng số lượng sản phẩm đã bán: {0} Tổng tiền từ các sản phẩm đã bán: {1}$", totalAllProductSold, totalMoney);
            System.Console.WriteLine("Danh sách sản phẩm đã bán: ");
            OrderDao.Show(orderList, listVg, listCb);
        }


        static void CaseMenuCustomer(ProductsDAO listPr)
        {
            int choose;
            bool flag = true;
            do
            {
                System.Console.WriteLine("--- Quản lý khách hàng ---");
                System.Console.WriteLine("1. Thêm khách hàng từ file");
                System.Console.WriteLine("2. Show danh sách khách hàng");
                System.Console.WriteLine("3. Thoát");
                System.Console.WriteLine("Choose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        break;
                    case 2:
                        SubMenuCustomer_2(listPr);
                        break;
                    case 3:
                        System.Console.WriteLine("Thoát!");
                        break;
                    default:
                        System.Console.WriteLine("Chọn sai. Vui lòng chọn lại");
                        break;
                }
                if(choose == 3) flag = false;
            } while (flag == true);
        }
        public static void SubMenuCustomer_1()
        {
            try
            {
                // b1: tạo kết nối tới nguồn dữ liệu - file .txt
                using(StreamReader sr = new StreamReader("E:\\CSharp\\Assignment\\CustomerInfor.txt", System.Text.Encoding.UTF8))
                {
                    //b2: thực thi đọc từng dòng trong file
                    string line = "";
                    DateTime date1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] part = new string[3];
                        part = line.Split(new char[] { ',' });
                        if(part.Length != 3)
                        {
                            System.Console.WriteLine("\"{0}\" line không hợp lệ ", line);
                        } 
                        else
                        {
                            // trường hợp thông tin trên 1 dòng không hợp lệ
                            if(part[0].Length != 4 && part[0].Trim().Equals("") && part[0].Contains(" "))
                            {
                                System.Console.WriteLine("Mã khách hàng bắt buộc có 4 ký tự");
                            }
                            if(part[1].Trim().Equals(""))
                            {
                                System.Console.WriteLine("Tên khách hàng không được để trống");
                            }
                            if(!DateTime.TryParse(part[2], out date1))
                            {
                                System.Console.WriteLine("Thời gian không hợp lệ");
                            }

                            // trường hợp hợp lệ
                            if(part[0].Length == 4 
                               && !part[0].Trim().Equals("")
                               && !part[0].Contains(" ") 
                               && (part[1]) != null 
                               && !part[1].Trim().Equals("") 
                               && DateTime.TryParse(part[2], out date1))
                            {
                                if(KhachHangDao.ValidateCustomer(part[0]))
                                {
                                    KhachHangDao.AddCustomerByInfor(part[0], part[1], part[2]);
                                    System.Console.WriteLine("Thêm khách hàng thành công");
                                }
                                else System.Console.WriteLine("Thông tin khách hàng đã tồn tại");
                            }
                            else
                            {
                                System.Console.WriteLine("Thêm khách hàng thất bại");
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void SubMenuCustomer_2(ProductsDAO listPr)
        {
            //Console.WriteLine("2. SHOW CUSTOMER LIST");
            KhachHangDao.ShowAllCustomer(KhachHangDao.ListCustomer);
            Order order = new Order();
            order.input(listPr);
        }


        public static void AddDataBase(VegesDAO vg, ProductsDAO pr)
        {
            Vegestable vegestable = new Vegestable();
            vg.ListVG.Add(vegestable = new Vegestable
            {
                id = 10,
                codePr = "1000",
                namePr = "hoa hong",
                price = 10.99f,
                category = "hoa",
                created_date = DateTime.Now,
                update_date = DateTime.Now
            });
            pr.ListPr.Add(vegestable);
            Vegestable vegestable1 = new Vegestable();
            vg.ListVG.Add(vegestable1 = new Vegestable
            {
                id = 11,
                codePr = "1001",
                namePr = "hoa mai",
                price = 12,
                category = "hoa",
                created_date = DateTime.Now,
                update_date = DateTime.Now
            });
            pr.ListPr.Add(vegestable1);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Assignment
{
    public class ComboDAO
    {
        List<Combo> listCombo;

        public ComboDAO()
        {
            ListCombo = new List<Combo>();
        }

        public ComboDAO(List<Combo> listCombo)
        {
            this.ListCombo = listCombo;
        }

        public List<Combo> ListCombo { get => listCombo; set => listCombo = value; }

        public void comboShowMenu(ProductsDAO dsPr)
        {
            
        }

        // ADD Combo
        public void newCombo(Combo cb, ProductsDAO dsPr)
        {
            if(cb == null)
            {
                System.Console.WriteLine("Tạo combo thất bại");
            }
            else
            {
                listCombo.Add(cb);
                dsPr.ListPr.Add(cb);
            }
        }
        public void inCombo()
        {
            if(this.ListCombo != null)
            {
                foreach(Combo cb in listCombo)
                {
                    System.Console.WriteLine("- {0}",cb.ToString());
                    foreach (Vegestable vg in cb.Vegestables)
                    {
                        System.Console.WriteLine(string.Format("   + {0}",vg.ToString()));
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Danh sách trống");
            }
        }
        public void AddVegInCombo(VegesDAO listVg, ProductsDAO dsPr)
        {
            string maCb;
            if(this.ListCombo.Count > 0)
            {
                while (true)
                {
                    System.Console.WriteLine("Nhập mã combo: ");
                    maCb = Console.ReadLine();
                    int test = 0;
                    int test2 = 0;
                    foreach(Combo cb in this.ListCombo)
                    {
                        if(maCb.Equals(cb.CodePr))
                        {
                            test2++;
                            if(checkActive(cb.Status)==1)
                            {
                                test++;
                            }
                            else if(checkActive(cb.Status)==0)
                            {
                                System.Console.WriteLine("Combo chưa được Active. Bạn có muốn Active ko? (Bấm y : đồng ý)");
                                string accept = Console.ReadLine();
                                if(accept.Equals("y"))
                                {
                                    cb.Status = "Active";
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if(test2 == 0)
                        {
                            System.Console.WriteLine("Mã combo sai hoặc không tồn tại!");
                        }
                    if(test > 0) break;
                }
                
                foreach(Combo cb in this.ListCombo)
                {
                    
                    if(maCb.Equals(cb.CodePr))
                    {
                        System.Console.WriteLine("Nhập mã vegestable: ");
                        string maVg = Console.ReadLine();
                        string[] arrListStr = maVg.Split(new char[] { ',' });
                        
                        for(int i = 0; i < arrListStr.GetLength(0); i++)
                        {
                            int vgcount = 0;
                            foreach(Vegestable vg in listVg.ListVG)
                            {
                                if(vg.CodePr.Equals(arrListStr[i]))
                                {   
                                    vgcount++;
                                    cb.Vegestables.Add(vg);
                                    System.Console.WriteLine("Thêm vegestable mã {0} vào combo thành công", arrListStr[i]);
                                }
                                // if(!vg.CodePr.Equals(arrListStr[i]))
                                // {
                                //     System.Console.WriteLine("Mã vegestable {0} không tồn tại!", arrListStr[i]);
                                // }
                            }
                            if(vgcount == 0)
                                {
                                    System.Console.WriteLine("Mã vegestable {0} không tồn tại!", arrListStr[i]);
                                }
                        }
                    }
                    
                }
            }
            if(this.ListCombo.Count == 0)
            {
                System.Console.WriteLine("Chưa có mã combo trong dữ liệu");
                System.Console.WriteLine("Bạn có muốn tạo mã combo mới? (y : đồng ý)");
                string confirm = Console.ReadLine();
                if(confirm.Equals("y"))
                {
                    do
                    {
                        Combo cb = new Combo();
                        cb.input(dsPr);
                        newCombo(cb, dsPr);
                        System.Console.WriteLine("Tiếp tục tạo Combo? (Bấm n: stop)");
                        confirm = Console.ReadLine();
                    } while (!confirm.Equals("n"));
                }
            }
        }

        public int checkActive(string Status)
        {
            if(Status.Equals("Active"))
            {
                return 1;
            }
            if(Status.Equals("Unactive"))
            {
                return 0;
            }
            return 0;
        }

        public void searchCombo()
        {
            string maTimKiem;
            string confirm = "";
            do
            {
                int count = 0;
                System.Console.WriteLine("Nhập mã tìm kiếm: ");
                maTimKiem = Console.ReadLine();
                foreach(Combo cb in listCombo)
                {
                    if(maTimKiem.Equals(cb.CodePr))
                    {
                        count++;
                        System.Console.WriteLine("- {0}",cb.ToString());
                        foreach (Vegestable vg in cb.Vegestables)
                        {
                            System.Console.WriteLine(string.Format("   + {0}",vg.ToString()));
                        }
                    }
                    
                }
                if(count == 0) System.Console.WriteLine("Mã combo sai hoặc không tồn tại");
                System.Console.WriteLine("Bạn có muốn tiếp tục? (Bấm n : stop)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("n"));
        }
        // In ma combo
        public void inCodeCombo()
        {
            if(listCombo != null)
            {
                System.Console.WriteLine("List mã combo: ");
                foreach(Combo cb in listCombo)
                {
                    System.Console.Write(string.Format("{0,-6}", cb.CodePr));
                }
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Danh sách trống");
            }
        }
        
    }
}
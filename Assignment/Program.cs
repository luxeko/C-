using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int check;
            bool flag = true;
            ProductsDAO listPr = new ProductsDAO();
            
            do
            { 
                showMenu();
                check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        
                        Products pr = new Products();
                       
                        System.Console.WriteLine("1. CRUD Vegestable"); 
                        pr.input();
                        listPr.addPr(pr);
                        listPr.inDanhSachSP();
                        break;
                    case 2:
                        System.Console.WriteLine("2. CRUD Combo");
                        break;
                    case 3:
                        System.Console.WriteLine("3. ALL Products");
                        break;
                    case 4:
                        System.Console.WriteLine("4. CRUD Bills");
                        break;
                    case 5:
                        System.Console.WriteLine("5. Reports");
                        break;
                    case 6:
                        System.Console.WriteLine("Thank you!");
                        break;
                    default:
                        System.Console.WriteLine("Error number! Please choose again");
                        break;
                }
                
                if(check == 6) flag = false;
            } while (flag == true);
        }
        static void showMenu()
        {
            System.Console.WriteLine("---- Quan ly don hang san pham ----");
            System.Console.WriteLine("1. CRUD Vegestable");
            System.Console.WriteLine("2. CRUD Combo");
            System.Console.WriteLine("3. ALL Products");
            System.Console.WriteLine("4. CRUD Bills");
            System.Console.WriteLine("5. Reports");
            System.Console.WriteLine("6. Exit!");
            System.Console.WriteLine("Choose: ");
        }
    }
}

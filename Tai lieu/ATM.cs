using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATM
    {
        Account account = new();
        public void CheckPin()
        {
            int numberOfInput = 1;
            while (true)
            {
                Console.Write("Nhap ma PIN: ");
                String pin = Console.ReadLine();
                if (pin.Equals(account.GetPin()))
                {
                    Console.WriteLine("Verify successfully");
                    ExecMenu();
                    break;
                }
                Console.WriteLine($"Sai ma PIN. Nhap lai. Con lai {3 - numberOfInput} lan nhap.");
                numberOfInput += 1;
                if (numberOfInput > 3)
                {
                    Console.WriteLine("Tai khoan da bi khoa do nhap sai qua 3 lan");
                    account.SetStatus(0);
                    break;
                }
            }
        }

        public void ExecMenu()
        {
            string confirm;
            do
            {
                int choice;
                Console.WriteLine("ATM Menu:\n1. Kiem tra so du\n2. Rut tien\n3. Nap tien");
                while (true)
                {
                    Console.Write("Chon chuc nang: ");
                    Int32.TryParse(Console.ReadLine(), out choice);
                    if (choice == 1 | choice == 2 | choice == 3) break;
                    Console.WriteLine("Nhap 1-4");
                }
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithDraw();
                        break;
                    case 3:
                        AddFund();
                        break;
                }
                Console.WriteLine("Tiep tuc? Nhap y de tiep tuc");
                confirm = Console.ReadLine();
            } while (confirm.Equals("y"));
        }

        public void CheckBalance()
        {
            Console.WriteLine("So du hien tai: {0:n0}", account.GetBalance());
        }

        public void WithDraw()
        {
            int ammountOfMoney;
            while (true)
            {
                Console.Write("Nhap so tien can rut: ");
                Int32.TryParse(Console.ReadLine(), out ammountOfMoney);
                if (ammountOfMoney >= 50000 & (ammountOfMoney % 2 == 0)) break;
                else Console.WriteLine("So tien rut toi thieu 50000 va chia het cho 50000");
            }
            if (account.GetBalance() - 10000 >= ammountOfMoney)
            {
                account.SetBalance(account.GetBalance() - ammountOfMoney - 1100);
                Console.WriteLine("Da rut thanh cong");
                CheckBalance();
            }
            else Console.WriteLine("So du khong du");
        }

        public void AddFund()
        {
            while (true)
            {
                Console.Write("Nhap so tien can nap: ");
                Int32.TryParse(Console.ReadLine(), out int ammountOfMoney);
                if (ammountOfMoney > 0)
                {
                    account.SetBalance(account.GetBalance() + ammountOfMoney);
                    Console.WriteLine("Da nap thanh cong");
                    CheckBalance();
                    break;
                }
                else Console.WriteLine("So tien nap phai > 0");
            }
        }
    }
}

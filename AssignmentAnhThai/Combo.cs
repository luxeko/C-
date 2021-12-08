using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Combo : Product
    {
        public List<Vegestable> ListVegesCombo { get; set; }
        public int Status { get; set; }
        public Combo(List<Vegestable> listVegesCombo, int status)
        {
            ListVegesCombo = listVegesCombo;
            Status = status;
        }
        public Combo()
        {
            //Phải khởi tạo list
            ListVegesCombo = new List<Vegestable>();
        }
        public override void Input(bool updateOrNot)
        {
            string choose = "";
            int num;
            bool resultStatus;
            base.Input(updateOrNot);
            if (!updateOrNot)
            {
                Console.Write("Create a list product for combo now? (skip = n): ");
                choose = Console.ReadLine();
                if (!choose.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    AddVegesToCombo();
            }
            while (true)
            {
                Console.Write("Active combo? (1 = active; 0: unactive): ");
                resultStatus = int.TryParse(Console.ReadLine(), out num);
                if (resultStatus)
                {
                    this.Status = num;
                    break;
                }
                else
                    Console.WriteLine("Input 1: active or 0: unactive");
            }
        }
        public void AddVegesToCombo()
        {
            string confirm = "";
            string inputCode;
            Console.WriteLine("Create vegestable list to combo: ");
            Console.WriteLine("Exist product list: ");
            ProductImpl.ShowAllProduct();
            while (true)
            {
                Console.Write("Enter code vegestable to add to combo: ");
                inputCode = Console.ReadLine();
                if (ComboImpl.IsCombo(inputCode))
                    Console.WriteLine("Cannot add combo to combo");
                else
                {
                    int result = AddVegesByCodeToCombo(inputCode);
                    if (result == 1)
                        Console.WriteLine("Add vegestable into combo successed");
                    else if (result == -1)
                        Console.WriteLine("Vegestable already exist in combo");
                    else
                        Console.WriteLine("Vegestable doesn't exist in product");
                    Console.Write("Add more vegestable to combo? (stop = n): ");
                    confirm = Console.ReadLine();
                    if (confirm.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                        break;
                }
            }
        }
        /*
        1: hợp lệ
        -1: không hợp lệ
        0: đã tồn tại
         */
        public int AddVegesByCodeToCombo(string codeVeges)
        {
            /*
            result = 1: hợp lệ - chưa trùng trong combo
            result = 0: không tồn tại sản phẩm
            result = -1: không hợp lệ - trùng trong combo
             */
            int result = ValidateVegesInCombo(codeVeges);
            if (result == 1)
            {
                Vegestable vegestable = VegestableImpl.SearchVegestableByCode(codeVeges);
                ListVegesCombo.Add(vegestable);
                return 1;
            }
            else if (result == -1)
                return -1;
            else
                return 0;
        }
        /*
        Check code vegestable đã có trong combo chưa?
        true: hợp lệ (chưa tồn tại veges trong list)
        false: không hợp lệ (đã tồn tại)
        1: hợp lệ - chưa trùng trong combo
        0: không tồn tại sản phẩm
        -1: không hợp lệ - trùng trong combo
        */
        public int ValidateVegesInCombo(string codeVeges)
        {
            /*
            result = true: chưa tồn tại trong ds sản phẩm => không hợp lệ
            result = false: tồn tại trong ds sản phẩm => hợp lệ được thêm
             */
            bool result = ProductImpl.ValidateCode(codeVeges, -1); //-1 coi như ID truyền vào khác ID product
            if (!result)
            {
                foreach (Vegestable item in ListVegesCombo)
                {
                    if (item.Code.Equals(codeVeges))
                        return -1;
                }
                return 1;
            }
            else
                return 0;
        }
        public void RemoveVegesFromCombo()
        {

        }
        public override string ToString()
        {
            string sStatus;
            if (Status == 1)
                sStatus = "Active";
            else
                sStatus = "Unactive";
            return base.ToString() + "\tStatus: " + sStatus;
        }
        public override void Output()
        {
            string sStatus;
            if (Status == 1)
                sStatus = "Active";
            else
                sStatus = "Unactive";
            base.Output();
            Console.WriteLine("Status: {0, -8}", sStatus);
        }
        public void ShowAllVegesInCombo()
        {
            Console.WriteLine("Vegestable in combo: ");
            foreach (Vegestable item in ListVegesCombo)
            {
                item.Output();
            }
        }
        /*
        ==========================LÀM SAU==========================
        add theo list 
        public void AddListVegesToCombo(Combo combo, string comboCode)
        {
            string inputCode;
            string confirm;
            string[] strArrInputCode;
            int count = 0;
            while (true)
            {
                Console.WriteLine("Exist vegestable: ");
                VegestableImpl.ShowAllVegestable();
                Console.WriteLine("Enter code vegestable to add to combo, comma separated and do not contains spaces (e.g: 1000,1001,1002): ");
                inputCode = Console.ReadLine();
                if (!inputCode.Contains(" "))
                {
                    strArrInputCode = inputCode.Split(',');
                    string[] distinctInput = strArrInputCode.Distinct().ToArray();
                    for (int i = 0; i < distinctInput.Length; i++)
                    {
                        //
                        Console.WriteLine(distinctInput[i]);
                        if (ComboImpl.IsCombo(distinctInput[i]))
                        {
                            Console.WriteLine(distinctInput[i] + " is combo, can't add combo to combo");
                            count++;
                        }
                        else
                        {
                            int result = ValidateVegesInCombo(distinctInput[i]);
                            if (result == 1)
                                AddVegesByCodeToCombo(distinctInput[i]);
                            else
                                Console.WriteLine("Vegestable doesn't exist in product");
                        }
                    }
                    if (count == distinctInput.Length)
                        Console.WriteLine("Add vegestable failed");
                    else if (count == 0)
                        Console.WriteLine("Add vegestable successed");
                    else
                        Console.WriteLine("Add successed {0} vegestable", distinctInput.Length - count);
                }
                else
                    Console.WriteLine("Vegetable lists must not have spaces and are separated by commas (e.g: 1000,1001,1002)");
                Console.Write("Add more vegestable to combo? (stop = n): ");
                confirm = Console.ReadLine();
                if (confirm.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    break;
            }
        }
        */
    }
}

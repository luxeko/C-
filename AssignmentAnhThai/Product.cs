using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Product
    {
        // PROPERTIES
        public static int incrementId = 0;
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int CountSale { get; set; }
        /*
        bool = true: update, ID not increment
        bool = false: add new, ID increment
         */
        public virtual void Input(bool updateOrNot)
        {
            if (!updateOrNot)
            {
                Id = ++incrementId;
                //
                CountSale = 0;
            }
            while (true)
            {
                Console.Write("Input code: ");
                this.Code = Console.ReadLine();
                bool result = ProductImpl.ValidateCode(Code, Id);
                if (Code.Length == 4 && !Code.Contains(" "))
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
                Console.Write("Input name: ");
                Name = Console.ReadLine();
                if (Name != null)
                {
                    break;
                }
                else
                    Console.WriteLine("Name can't be null");
            }

            while (true)
            {
                Console.Write("Input price: ");
                float parsePrice;
                bool result = float.TryParse(Console.ReadLine(), out parsePrice);
                if (result)
                {
                    if (parsePrice > 0)
                    {
                        Price = parsePrice;
                        break;
                    }
                    else
                        Console.WriteLine("Input price must be a positive number");
                }
                else
                    Console.WriteLine("Input price must be a number");
            }
        }
        public override string ToString()
        {
            return "ID: " + Id + "\tCode: "
                + Code + "\tName: "
                + Name + "\tPrice: "
                + Price;
        }
        public virtual void Output()
        {
            Console.Write("ID: {0, -3}Code: {1, -5}Name: {2, -10}Price: {3, -8}"
                , Id, Code, Name, Price);
        }
    }
}

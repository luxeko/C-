using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Vegestable : Product
    {
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Vegestable(string category, DateTime createdDate, DateTime updateDate)
        {
            Category = category;
            CreatedDate = createdDate;
            UpdateDate = updateDate;
        }
        public Vegestable()
        {
        }
        public override void Input(bool updateOrNot)
        {
            base.Input(updateOrNot);
            while (true)
            {
                Console.Write("Input category: ");
                Category = Console.ReadLine();
                if (Category != null)
                    break;
                else
                    Console.WriteLine("Category can't be null");
            }
            if (!updateOrNot)
                CreatedDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }
        public override string ToString()
        {
            return base.ToString() 
                + "\tCategory: " + Category 
                + "\tCreated date: " + CreatedDate
                + "\tUpdate date: " + UpdateDate;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Category: {0, -7}CreatedDate: {1, -20}UpdateDate: {2, -20}"
                , Category, CreatedDate, UpdateDate);
        }
    }
}

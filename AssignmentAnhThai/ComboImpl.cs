using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class ComboImpl
    {
        public static List<Combo> ComboList { get; set; }
        public static bool AddCombo()
        {
            Combo combo = new Combo();
            // false: thêm mới, true: cập nhật
            combo.Input(false);
            ComboImpl.ComboList.Add(combo);
            ProductImpl.ProductList.Add(combo);
            return true;
        }
        /*
        True: Hợp lệ (chưa tồn tại)
        False: Không hợp lệ (đã tồn tại)
         */
        public static void ShowAllCombo(List<Combo> comboList)
        {
            foreach (Combo item in comboList)
            {
                item.Output();
                item.ShowAllVegesInCombo();
                Console.WriteLine("--------------------");
            }
        }
        /*
        true: là combo
        false: không là combo
         */
        public static bool IsCombo(string comboCode)
        {
            foreach (Combo item in ComboList)
            {
                if (item.Code == comboCode)
                    return true;
            }
            return false;
        }
        public static List<Combo> ComboContainVeges(string vegesCode)
        {
            // Way 1:
            List<Combo> result = new List<Combo>();
            int count = 0;
            foreach (Combo comboItem in ComboList)
            {
                foreach (Vegestable vegesItem in comboItem.ListVegesCombo)
                {
                    if (vegesCode.Equals(vegesItem.Code))
                    {
                        result.Add(comboItem);
                        count++;
                    }    
                }    
            }
            if (count == 0)
                return null;
            return result;
            /*
            True: contain
            False: nocontain
            */
            /*
            Way 2:
            for (int i = 0; i < ComboImpl.ComboList.Count; i++)
            {
                Combo item = ComboImpl.ComboList[i];
                for (int j = 0; j < item.ListVegesCombo.Count; j++)
                    if (vegesCode == item.ListVegesCombo[j].Code)
                        return true;
            }
            return false;
            */
        }
        public static Combo SearchCombo(string comboCode)
        {
            foreach (Combo item in ComboList)
            {
                if (item.Code.Equals(comboCode))
                    return item;
            }
            return null;
        }
        public static void ShowAllComboId()
        {
            foreach (Combo item in ComboList)
                Console.Write(item.Code + "   ");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Method
    {
        public static string ConvertDateTimeToId()
        {
            string sDateTime;
            string code = "";
            DateTime now = DateTime.Now;
            sDateTime = now.ToString();
            string[] datePath = sDateTime.Split('/', ':', ' ');
            // date: 06/12/2021 19:03:50 => 06122021-190350
            for (int i = 0; i < datePath.Length; i++)
                code += datePath[i];
            code = code.Insert(8, "-");
            return code;
        }
    }
}

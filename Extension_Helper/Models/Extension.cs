using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Extension_Helper.Models
{
    internal static class Extension
    {
        public static (bool, string) IsOdd(this int num)
        {
            if (num is 0) return (false,"Daxil etdiyiniz eded ne tek ne de cutdur") ;
            else if (num % 2 is 0) return (false,"Bu eded tek deyil"); ;
            return (true,"Bu eded tekdir");
        }

        public static (bool,string) IsEven(this int num) 
        {
            if (num is 0) return (false,"Daxil etdiyiniz eded ne tek ne de cutdur") ;
            else if (num % 2 is 0) return (true, "Bu eded cutdur");
            return (false,"Bu eded cut deyil");
        }

        public static (bool,string) HasDigit(this string str)
        {
            foreach (char item in str)
            {
                if (char.IsDigit(item)) return (true, "Bu sozun terkibinde reqem var");
            }
            return (false, "Bu sozun terkibinde reqem yoxdur");
        }

        public static string ToCapitalize(this string str)
        {
            if (str.Trim() is null || str.Trim() is "")
            {
                return "Bos gonderile bilmez";
            }
            str = str.Trim();   
            return str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        }

        public static string ToCapitalize2(this string str)
        {
            if (str.Trim() is null || str.Trim() is "")
            {
                return "Bos gonderile bilmez";
            }
            StringBuilder newstr = new StringBuilder();
            return newstr.Append(char.ToUpper(str[0])).Append(str.Substring(1).ToLower()).ToString();
        }
    }
}

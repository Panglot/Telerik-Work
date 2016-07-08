using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_Library
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int start, int length)
        {
            var forReturn = new StringBuilder();

            for (int i = start; i < start+length; i++)
            {
                forReturn.Append(str[i]);
            }
            return forReturn;
        }

       
    }
}

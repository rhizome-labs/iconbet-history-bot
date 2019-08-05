using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IconBetTransactionHistory
{
    public static class NumericHelper
    {
       public static string Loop2ICX(string bigInt, int wholeNumberLength, bool trimTrailing = true)
        {
            var result = string.Empty;
            var str = bigInt;

            if(wholeNumberLength >= 0)
            {
                str = str.PadLeft(wholeNumberLength, '0');
                var wholeNum = str.Substring(0, wholeNumberLength);
                var floatNum = str.Length > wholeNumberLength ? str.Substring(wholeNumberLength) : "0";
                result = wholeNum + "." + floatNum;
                result = result.TrimStart(new char[] { '0' });
            }


            if (trimTrailing)
            {
                result = result.TrimEnd(new char[] { '0' });
            }

            if (result.EndsWith("."))
            {
                result += "0";
            }

            return result;
        }
    }
}

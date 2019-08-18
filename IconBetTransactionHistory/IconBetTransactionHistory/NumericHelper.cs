using System.Numerics;
using System;
namespace IconBetTransactionHistory
{
    public static class NumericHelper
    {
        public static string Loop2ICX(string bigInt, bool trimTrailing = true)
        {
            BigInteger icxloop = BigInteger.Parse(bigInt);

            BigInteger numericBase = BigInteger.Parse("10");

            BigInteger result = icxloop / BigInteger.Pow(numericBase, 18);

            return result.ToString();
        }
    }
}

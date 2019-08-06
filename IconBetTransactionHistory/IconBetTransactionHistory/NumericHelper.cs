namespace IconBetTransactionHistory
{
    public static class NumericHelper
    {
        private static int FloatingPointLength = 18;

        public static string Loop2ICX(string bigInt, bool trimTrailing = true)
        {
            var result = string.Empty;
            var str = bigInt;

            var padded = str.PadLeft(FloatingPointLength, '0');
            if (padded.Length <= FloatingPointLength)
            {
                result = "0." + padded;
            }
            else
            {
                var wholeNumberLength = padded.Length - FloatingPointLength;
                var wholeNum = padded.Substring(0, wholeNumberLength);
                var floating = padded.Substring(wholeNumberLength);

                result = wholeNum + "." + floating;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemConversion
{
    class NumberSystemConversion
    {
        private static Dictionary<string, int> myDict = new Dictionary<string, int>() {{"0",0}, { "1", 1 }, { "2",2}, { "3", 3 }, { "4",4}, { "5",5},
            {"6",6 },{"7",7}, {"8",8},{"9",9},{"A",10},{"B",11},{"C",12},{"D",13},{"E",14},{"F",15 } };

        public static int GetRealValue(string currentChar)
        {
            int result = -1;
            foreach (var item in myDict)
            {
                if (currentChar == item.Key)
                {
                    result = item.Value;
                }
            }
            return result;
        }

        public static string GetStringValue(int currentChar)
        {
            string result = "";
            foreach (var item in myDict)
            {
                if (currentChar == item.Value)
                {
                    result = item.Key;
                }
            }
            return result;
        }

        public static string DecimalToNAry(string num, int basis)
        {
            int x = int.Parse(num);
            int rest = 0;
            int quotient = 0;
            string result = "";
            while (x > 0)
            {
                quotient = x / basis;
                rest = x % basis;
                x = quotient;
                result = GetStringValue(rest) + result;
                //result = rest + result;
            }
            if (result == "") result = "0";
            return result;
        }

        public static string NAryToDecimal(string num, int basis)
        {
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result = GetRealValue(num[i].ToString()) * (int)Math.Pow(basis, num.Length - i - 1) + result;
                //result = int.Parse(num[i].ToString()) * (int)Math.Pow(basis, num.Length - i - 1) + result;
            }
            return result.ToString();
        }

        public static string XAryToYAry(string num, int baseX, int baseY)
        {
            string result = "";
            result = DecimalToNAry(NAryToDecimal(num, baseX),baseY);
            return result;
        }
    }
}

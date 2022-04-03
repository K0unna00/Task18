using System;
using System.Collections.Generic;
using System.Text;

namespace Extentions
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            return !(num % 2 == 0);
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item)) return true;
            }
            return false;
        }
        public static string Capilatize(this string str)
        {
            StringBuilder strB = new StringBuilder("");
            strB.Append(char.ToUpper(str[0]));
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ')
                {
                    strB.Append(char.ToUpper(str[i]));
                }
                else
                {
                    strB.Append(str[i]);
                }
            }
            return strB.ToString();
        }
        public static int[] GetValueIndexes(this string str, char ch)
        {
            int[] intArr = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Array.Resize(ref intArr, intArr.Length + 1);
                    intArr[intArr.Length - 1] = i;
                }
            }
            return intArr;
        }

        public static bool IsFullname(this string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item==' ') count ++;
            }
            if (count == 1)
            {
                string[] strArr = str.Split(" ", 2);
                if (char.IsUpper(strArr[0][0]) && char.IsUpper(strArr[1][0]))
                {
                    for (int i = 1; i < strArr[0].Length; i++)
                    {
                        if (char.IsUpper(strArr[0][i]))
                        {
                            return false;
                        }
                    }
                    for (int i = 1; i < strArr[1].Length; i++)
                    {
                        if (char.IsUpper(strArr[1][i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
            
        }

        public static bool IsGroupNo(this string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
            {
                return true;
            }
            return false;
        }
        
    }

}

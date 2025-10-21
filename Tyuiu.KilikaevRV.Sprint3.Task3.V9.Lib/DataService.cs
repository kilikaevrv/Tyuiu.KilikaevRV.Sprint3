using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KilikaevRV.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            char[] chars = value.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    chars[i] = item;
                }
            }

            return new string(chars);
        }
    }
}
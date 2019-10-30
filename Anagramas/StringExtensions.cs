using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class CharArrayExtensions
    {
        public static string ToString(this char[] charArray)
        {
            string text = string.Empty;

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                text += charArray[i];
            }

            return text;
        }
    }
}

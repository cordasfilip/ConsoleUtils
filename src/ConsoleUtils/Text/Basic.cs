using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtils.Text
{
    public static class Basic
    {
        public static void WriteCenter(this IWriter writer, string text, int length)
        {
            if (text.Length > length)
            {
                writer.WriteEllipsis(text, length);
            }
        }

        public static void WriteEllipsis(this IWriter writer, string text, int length)
        {

        }
    }
}

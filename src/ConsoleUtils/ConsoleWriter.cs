using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtils
{
    public class ConsoleWriter : IWriter
    {
        public int Width => Console.WindowWidth;

        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtils
{
    public interface IWriter
    {
        int Width { get; }

        void Write(string text);

        void WriteLine();
    }
}

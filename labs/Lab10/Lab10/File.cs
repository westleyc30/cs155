using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class File : Document
    {
        public string Pathname { get; set; }

        public File(string _pathname, string _text)
        {
            Pathname = _pathname;
            Text = _text;
        }

        override
        public string ToString()
        {
            return $"{Pathname}\n\n{Text}";
        }
    }
}

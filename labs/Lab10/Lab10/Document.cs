using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Document
    {
        public string Text { get; set; }
        public Document(string _text)
        {
            Text = _text;
        }
        public Document()
        {

        }
        override
        public string ToString()
        {
            return Text;
        }
    }
}

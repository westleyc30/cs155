using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Email : Document
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Title { get; set; }
       
        public Email(string _text, string _sender, string _recipient, string _title)
        {
            Text = _text;
            Sender = _sender;
            Recipient = _recipient;
            Title = _title;
        }

        override
        public string ToString()
        {
            return $"Sender: {Sender}\nRecipient: {Recipient}\nTitle: {Title}\n{Text}:";
        }
    }
}

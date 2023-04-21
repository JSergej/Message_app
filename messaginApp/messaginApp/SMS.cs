using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messaginApp
{
    internal class SMS : Message
    {
       public SMS()
        {

        }
        public SMS(int id, string status, string text, bool isGroupMessage,
            string sender, string recipient, bool mms)
        {
            ID = id;
            Status = status;
            Text = text;
            IsGroupMessage = isGroupMessage;
            Recipient = recipient;
            Sender = sender;
            MMS = mms;

        }
        //public int ID { get; set; }
        //public string Status { get; set; }
        //public string Text { get; set; }
        //public bool IsGroupMessage { get; set; }
        //public string Sender { get; set; }
        //public string Recipient { get; set; }
        //public bool MMS { get; set; }

    }
}

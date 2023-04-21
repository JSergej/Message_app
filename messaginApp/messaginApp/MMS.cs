using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messaginApp
{
    internal class MMS : Message
    {
        public bool Picture { get; set; }
        public bool Audio { get; set; }
        public bool Video { get; set; }
        public string FileName { get; set; }


        public MMS()
        {

        }
        public MMS(int id, string status, string text, bool isGroupMessage,
            string sender, string recipient, bool mms,bool picture, bool audio, bool video, string fileName)
        {
            ID = id;
            Status = status;
            Text = text;
            IsGroupMessage = isGroupMessage;
            Recipient = recipient;
            Sender = sender;
            MMS = mms;
            Picture = picture;
            Audio = audio;
            Video = video;
            FileName = fileName;


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

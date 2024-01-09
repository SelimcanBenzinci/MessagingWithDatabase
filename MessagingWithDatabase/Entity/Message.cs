using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{
    public class Message : IMessage
    {
        [Key]
        public int? MessageID { get; set; }

        public int? SenderUserID { get; set; }

        public int? ReceiverUserID { get; set; }

        public string MessageText { get; set; }

        public DateTime time{ get; set; }

        public bool bSeen { get; set; }


        //Interface Methods
        public int? GetSenderUser()
        {
            return SenderUserID;
        }

        public string GetMessageText()
        {
            return MessageText;
        }

        public bool GetbSeen()
        {
            return bSeen;
        }

        public int? GetMessageID()
        { return MessageID; }

        public DateTime? GetDateTime()
            { return time; }
    }
}

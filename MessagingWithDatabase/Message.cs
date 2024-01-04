using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{
    public class Message
    {
        [Key]
        public int? MessageID { get; set; }

        public int? SenderUserID { get; set; }

        public int? ReceiverUserID { get; set; }

        public string MessageText { get; set; }

        public DateTime time{ get; set; }

        public bool bSeen { get; set; }
    }
}

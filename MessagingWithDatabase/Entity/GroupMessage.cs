using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{
    public class GroupMessage : IMessage
    {

        [Key]
        public int? GroupMessageID { get; set; }

        public int? SenderUserID { get; set; }

        public Group group { get; set; }

        public string MessageText { get; set; }

        public DateTime time { get; set; }

        public Dictionary<User, bool> bSeen = new Dictionary<User, bool>();


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
            
            foreach (bool item in bSeen.Values)
            {
                if (item == false)
                    return false; 
            }
            return true;
        }

        public int? GetMessageID() { return GroupMessageID; }

        public DateTime? GetDateTime()
        { return time; }

    }
}

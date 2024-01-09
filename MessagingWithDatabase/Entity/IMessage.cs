using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{
    public interface IMessage
    {

        public int? GetSenderUser();

        public string GetMessageText();

        public bool GetbSeen();

        public int? GetMessageID();

        public DateTime? GetDateTime();

    }
}

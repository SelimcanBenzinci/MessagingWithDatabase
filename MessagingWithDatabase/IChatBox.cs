using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{
    public interface IChatBox
    {

        public int? GetID();
        public string GetName();
        public byte[] GetImage();
        public string GetLastMessage();


        
    }
}

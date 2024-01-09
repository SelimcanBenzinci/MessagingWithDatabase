using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MessagingWithDatabase
{

    public class Group : IChatBox
    {
        [Key]
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] ImageByteArray { get; set; }

        public List<User> Users { get; set; } = new();

        //public User GroupAdmin { get; set; }

        public DateTime CreationTime { get; set; }

        //Interface Methods
        public string GetName()
        {
            return Name;
        }

        public string GetLastMessage()
        {
            return Description;
        }
        public byte[] GetImage()
        {
            return ImageByteArray;
        }

        public int? GetID()
        {
            return Id;
        }

    }


    public class GroupUser
    {

        public int? GroupID { get; set; }

        public int? UserID { get; set; }

    }

}

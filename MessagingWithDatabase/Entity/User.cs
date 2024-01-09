using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{

    public class User : IChatBox
    {

        public enum Visibilty
        {
            Herkes = 0,
            Ekli = 1,
            Hickimse = 2,
        }

        [Key]
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public byte[] ImageByteArray { get; set; }

        [EnumDataType(typeof(Visibilty))]
        public Visibilty visibilty { get; set; }

        [StringLength(250)]
        [Required]
        public string Password { get; set; }

        [StringLength(250)]
        [Required]
        public string Email { get; set; }

        public List<int> FriendIDs { get; set; }

        public List<Group> Groups { get; set; } = new();






        //Interface Methods
        public string GetName()
        {
            return Name;
        }

        public string GetLastMessage() 
        {
            return Status;
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



}

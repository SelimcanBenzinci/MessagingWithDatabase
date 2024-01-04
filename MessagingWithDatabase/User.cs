using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{

    public class User
    {
        public enum Visibilty
        {
            Herkes = 0,
            Ekli = 1,
            Kimse = 2,
        }


        [Key]
        public int? UserID { get; set; }

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

        public List<int?> FriendIDs { get; set; }

    }



}

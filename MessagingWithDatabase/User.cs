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
        [Key]
        public int? UserID { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Password { get; set; }

        public string Email { get; set; }

        public List<int?> FriendIDs { get; set; }

    }



}

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add-migration CreateMessagingWithDB
//update-database –verbose

namespace MessagingWithDatabase
{
    public class Model : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MessagingWithDB;User Id=sa; Password=ask12345;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public List<User> GetUsers()
        {
            List<User> asd = Users.ToList();
            return asd;
        }

        public void AddUser(string name)
        {

            User user = new User()
            {
                UserID = null,
                Name = name,
                Password = "asd",
            };

            Add(user);
            SaveChanges();
        }
    }
}

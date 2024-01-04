using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MessagingWithDatabase.User;

//add-migration CreateMessagingWithDB
//update-database –verbose

namespace MessagingWithDatabase
{
    public class Model : DbContext
    {
        public Controller controller { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MessagingWithDB;User Id=sa; Password=asd;TrustServerCertificate=True;");
        }

        public Model()
        {

        }

        public Model(Controller cntrl)
        {
            controller = cntrl;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().OwnsOne(x => x.FriendIDs);
        }

        public List<User> GetUsers()
        {
            List<User> users = Users.ToList();
            return users;
        }

        public void AddUser(string name, string password)
        {

            User user = new User()
            {
                UserID = null,
                Name = name,
                Password = password,
                Email = "",
                FriendIDs = new List<int?>(),
            };

            Add(user);
            SaveChanges();
        }


        public User ControlUser(string name, string password) 
        {

            foreach (User user in Users)
            {
                
                if (user.Name == name)
                {
                    if (user.Password == password)
                    {
                        return user;
                    }
                }
            }

            return null;

        }

        public void AddFriend(User user)
        {
            controller.CurrentUser.FriendIDs.Add(user.UserID);
            
            SaveChanges();

        }

        public List<User> GetFriends()
        {
            List<User> nUsers = new List<User>();

            foreach (int ID in controller.CurrentUser.FriendIDs)
            {
                User usr = Users.Where(x => x.UserID == ID).FirstOrDefault();
                if (usr != null) { nUsers.Add(usr); }
                
            }
            return nUsers;
        }

        public void SendMessage(User user1, User user2, string message) 
        {
            Message msg = new Message()
            {
                MessageID = null,
                MessageText = message,
                SenderUserID = user1.UserID,
                ReceiverUserID = user2.UserID,
                time = DateTime.Now,
                bSeen = false,
            };

            Add(msg);
            SaveChanges();
        }

        public List<Message> GetMessages(User currentUser, User targetUser) 
        {
            List < Message > msgs = new List < Message >();
            foreach (Message item in Messages)
            {
                if (item.SenderUserID == currentUser.UserID || item.ReceiverUserID == currentUser.UserID)
                {
                    if (item.SenderUserID == targetUser.UserID || item.ReceiverUserID == targetUser.UserID)
                    {
                        msgs.Add(item);
                    }
                } 
            }

            return msgs;
        }


    }
}

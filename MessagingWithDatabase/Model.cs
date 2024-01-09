using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MessagingWithDatabase.User;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.IdentityModel.Tokens;

//add-migration CreateMessagingWithDB
//update-database –verbose

namespace MessagingWithDatabase
{

    public class Model : DbContext
    {
        public Controller controller { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<GroupMessage> GroupMessages { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MessagingWithDB;User Id=sa; Password=Esad123:;TrustServerCertificate=True;MultipleActiveResultSets=True;");
        }

        public Model()
        {

        }

        public Model(Controller cntrl)
        {
            controller = cntrl;
            foreach (User item in Users)
            {
                List<GroupUser> grp = GroupUsers.Where(x => x.UserID == item.Id).ToList();
                foreach (GroupUser item2 in grp)
                {
                    item.Groups.Add(Groups.Where(x => x.Id == item2.GroupID).FirstOrDefault());
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().OwnsOne(x => x.FriendIDs);

            modelBuilder.Entity<Group>()
               .HasMany(e => e.Users)
               .WithMany(e => e.Groups)
               .UsingEntity<GroupUser>();
        }

        public List<User> GetUsers()
        {
            List<User> users = Users.ToList();
            return users;
        }
        public User GetUser(int? id)
        {
            return Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Group> GetGroups()
        {
            List<Group> groups = Groups.ToList();
            return groups;

        }

        public List<IChatBox> GetChatBoxs()
        {
            List<IChatBox> chatBoxes = new List<IChatBox>();

            foreach (int item in controller.CurrentUser.FriendIDs)
            {
                chatBoxes.Add(Users.Where(x => x.Id == item).FirstOrDefault());
            }


            foreach (Group item in Groups)
            {
                if (item.Users != null)
                {
                    if (item.Users.Contains(controller.CurrentUser))
                    {
                        chatBoxes.Add(item);
                    }

                }
            }

            return chatBoxes;
        }

        public void AddUser(string mail, string password)
        {

            User user = new User()
            {
                Id = null,
                Name = string.Empty,
                Status = string.Empty,
                visibilty = Visibilty.Herkes,
                ImageByteArray = new byte[0],
                Password = password,
                Email = mail,
                FriendIDs = new List<int>(),
            };

            Add(user);
            SaveChanges();
        }

        public void AddGroup(Group group)
        {
            Add(group);
            SaveChanges();
             
        }

        public void UpdateUser(User usr)
        {
            Update(usr);
            SaveChanges();
        }


        public User ControlUser(string email, string password)
        {

            foreach (User user in Users)
            {

                if (user.Email == email)
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
            controller.CurrentUser.FriendIDs.Add(user.Id.GetValueOrDefault());

            SaveChanges();

        }

        public List<User> GetFriends()
        {
            List<User> nUsers = new List<User>();

            foreach (int ID in controller.CurrentUser.FriendIDs)
            {
                User usr = Users.Where(x => x.Id == ID).FirstOrDefault();
                if (usr != null) { nUsers.Add(usr); }

            }
            return nUsers;
        }

        public void SendMessage(IChatBox chat, string message)
        {
            if (chat.GetType() == typeof(User))
            {
                Message msg = new Message()
                {
                    MessageID = null,
                    MessageText = message,
                    SenderUserID = controller.CurrentUser.Id,
                    ReceiverUserID = chat.GetID(),
                    time = DateTime.Now,
                    bSeen = false,
                };

                Add(msg);
                SaveChanges();
            }
            else
            {
                Dictionary<User, bool> bSeenT = new Dictionary<User, bool>();

                Group groupT = Groups.Where(x => x.Id == chat.GetID()).FirstOrDefault();

                foreach (User item in groupT.Users)
                {
                    bSeenT.Add(item, false);
                }

                GroupMessage msg = new GroupMessage()
                {
                    GroupMessageID = null,
                    SenderUserID = controller.CurrentUser.Id,
                    group = groupT,
                    MessageText = message,
                    time = DateTime.Now,
                    bSeen = bSeenT,
                };

                Add(msg);
                SaveChanges();
            }

        }

        public List<Message> GetMessages(User currentUser, User targetUser)
        {
            List<Message> msgs = new List<Message>();
            foreach (Message item in Messages)
            {
                if (item.SenderUserID == currentUser.Id || item.ReceiverUserID == currentUser.Id)
                {
                    if (item.SenderUserID == targetUser.Id || item.ReceiverUserID == targetUser.Id)
                    {
                        msgs.Add(item);
                    }
                }
            }

            return msgs;
        }

        public List<GroupMessage> GetGroupMessages(Group currentGroup)
        {
            List<GroupMessage> messages = new List<GroupMessage>();

            foreach (GroupMessage item in GroupMessages.ToList())
            {
                if (item.group == currentGroup)
                {
                    messages.Add(item);
                }
            }

            return messages;
        }

        public List<IMessage> GetIMessages(IChatBox currentChat)
        {
            List<IMessage> msgs = new List<IMessage>();

            if (currentChat.GetType() == typeof(User))
            {
                foreach (Message item in Messages)
                {
                    if (item.SenderUserID == currentChat.GetID() || item.ReceiverUserID == currentChat.GetID())
                    {
                        if (item.SenderUserID == currentChat.GetID() || item.ReceiverUserID == currentChat.GetID())
                        {
                            msgs.Add(item);
                        }
                    }
                }
            }
            else
            {
                foreach (GroupMessage item in GroupMessages)
                {
                    if (item.group.Id == currentChat.GetID())
                    {
                        msgs.Add(item);
                    }
                }
            }

            return msgs;
        }

    }

}

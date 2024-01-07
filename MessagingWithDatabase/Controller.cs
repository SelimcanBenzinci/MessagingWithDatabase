using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingWithDatabase
{
    public class Controller
    {
        public Model Model { get; set; }
        public Form1 mainForm { get; set; }

        public User CurrentUser { get; set; }
        public IChatBox CurrentChat { get; set; }

        public ICollection<User> GroupUsers { get; set; }

        public Controller()
        {
            Model = new Model(this);
            GroupUsers = new List<User>();

            Form1 mainForm = new Form1(this);

            Application.Run(mainForm);
            
        }

        public void populateChatBoxs(List<IChatBox> chatBoxes)
        {
            mainForm.flowLayoutPanel1.Controls.Clear();
            foreach (IChatBox user in chatBoxes)
            {
                if (user == CurrentUser)
                    continue;

                ChatChart chart = new ChatChart(this, user);
                mainForm.flowLayoutPanel1.Controls.Add(chart);
            }

            mainForm.AccountButton.Visible = true;
            mainForm.CreateGroupButton.Visible = true;
        }

        public void populateChat(IChatBox chatBox)
        {

            this.CurrentChat = chatBox;

            ChatMenu chatMenu = new ChatMenu(this);

            mainForm.panel1.Controls.Clear();
            mainForm.panel1.Controls.Add(chatMenu);
        }

    }
}

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
        public User TargetUser { get; set; }

        public Controller()
        {
            Model = new Model(this);

            Form1 mainForm = new Form1(this);

            Application.Run(mainForm);
            
        }

        public void populateUsers(List<User> users)
        {

            foreach (User user in users)
            {
                if (user == CurrentUser)
                    continue;

                UserChart chart = new UserChart(this);
                chart.ConfigureChart(user);
                mainForm.flowLayoutPanel1.Controls.Add(chart);
                Model.AddFriend(user);
            }            
            
        }

        public void populateChat(User targetUser)
        {
            this.TargetUser = targetUser;

            ChatMenu chatMenu = new ChatMenu(this);

            mainForm.panel1.Controls.Clear();
            mainForm.panel1.Controls.Add(chatMenu);
        }

    }
}

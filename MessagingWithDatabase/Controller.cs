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
                UserChart chart = new UserChart();
                chart.ConfigureChart(user.Name);
                mainForm.flowLayoutPanel1.Controls.Add(chart);
                Model.AddFriend(user);
            }

            List<User> friends =  Model.GetFriends();
            
            Model.SendMessage(CurrentUser, friends[1], "asdfgfdg");
        }

    }
}

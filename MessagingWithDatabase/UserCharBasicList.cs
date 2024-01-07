using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingWithDatabase
{
    public partial class UserCharBasicList : UserControl
    {
        public Controller controller { get; set; }
        public User usr { get; set; }

        public UserCharBasicList()
        {
            InitializeComponent();
        }

        public UserCharBasicList(Controller cntrl, User user)
        {
            InitializeComponent();
            controller = cntrl;
            usr = user;
            AddUserButton.Text = user.Name;
            AddUserButton.BackColor = Color.FromArgb(100, 150, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controller.GroupUsers.Contains(usr))
            {
                controller.GroupUsers.Remove(usr);

                AddUserButton.BackColor = Color.FromArgb(100, 150, 0, 0);
            }
            else
            {
                controller.GroupUsers.Add(usr);

                AddUserButton.BackColor = Color.FromArgb(100, 0, 150, 0);

            }
        }
    }
}

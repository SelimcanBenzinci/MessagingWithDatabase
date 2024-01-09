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
    public partial class UsersListView : UserControl
    {
        public Controller controller { get; set; }


        public UsersListView()
        {
            InitializeComponent();
        }
        public UsersListView(Controller cntr)
        {
            InitializeComponent();
            controller = cntr;

            controller.Model.GetFriends();

            List<User> users = controller.Model.GetNonFriends();

            foreach (User item in users)
            {
                AddUser addUser = new AddUser(controller, item);

                flowLayoutPanel1.Controls.Add(addUser);
            }
        }
    }
}

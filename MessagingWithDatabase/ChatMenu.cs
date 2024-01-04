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
    public partial class ChatMenu : UserControl
    {
        public User TargetUser { get; set; }

        public Controller controller { get; set; }
        public ChatMenu()
        {
            InitializeComponent();
        }

        public ChatMenu(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           controller.Model.SendMessage(controller.CurrentUser, TargetUser,textBox1.Text);
        }
    }
}

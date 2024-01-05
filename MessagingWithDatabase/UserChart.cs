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
    public partial class UserChart : UserControl
    {

        public Controller controller { get; set; }
        public User TargetUser { get; set; }

        public UserChart()
        {
            InitializeComponent();
        }

        public UserChart(Controller cntrl, User usr)
        {
            InitializeComponent();
            controller = cntrl;
            TargetUser = usr;
            button1.Text = usr.Email;
            statusLabel.Text = usr.Status;
            if (usr.ImageByteArray.Length != 0)
            {
                MemoryStream mem = new MemoryStream(usr.ImageByteArray);
                pictureBox1.Image = Image.FromStream(mem);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            controller.populateChat(TargetUser);
        }
    }
}

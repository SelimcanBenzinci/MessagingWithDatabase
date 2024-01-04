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
    public partial class Register : UserControl
    {
        public Controller controller { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        public Register(Controller cntrl)
        {
            InitializeComponent();

            controller = cntrl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Model.AddUser(MailText.Text, PasswordText.Text);

            Login login = new Login(controller);

            Parent.Controls.Add(login);

            Parent.Controls.Remove(this);
        }
    }
}

using Microsoft.VisualBasic.Logging;
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
    public partial class Login : UserControl
    {

        public Controller controller { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        public Login(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            User user = controller.Model.ControlUser(MailText.Text, PasswordText.Text);

            if (user != null)
            {
                label1.Text = user.Name;

                controller.CurrentUser = user;

                controller.populateUsers(controller.Model.GetUsers());

                Parent.Controls.Remove(this);
            }
            else
            {
                label1.Text = "Kullanıcı adı veya şifre yanlış";
            }

        }

        private void Kaydol_Click(object sender, EventArgs e)
        {
            Register register = new Register(controller);

            Parent.Controls.Add(register);

            Parent.Controls.Remove(this);
        }
    }
}

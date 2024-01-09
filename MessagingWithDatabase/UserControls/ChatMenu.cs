using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace MessagingWithDatabase
{
    public partial class ChatMenu : UserControl
    {
        public Controller controller { get; set; }

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        private int cntMessage = 0;

        public bool bGroupMenu = false;

        public ChatMenu()
        {
            InitializeComponent();
        }

        public ChatMenu(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;

            flowLayoutPanel1.VerticalScroll.Visible = true;

            Refresh();

            myTimer.Tick += new EventHandler(Refresh);

            myTimer.Interval = 500;
            myTimer.Start();
        }


        private void Refresh(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Enabled = true;

            int cntMsg = 0;


            cntMsg = controller.Model.GetIMessages(controller.CurrentChat).Count();


            if (cntMessage == cntMsg)
            {
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (IMessage item in controller.Model.GetIMessages(controller.CurrentChat))
            {
                MessageChart chart = new MessageChart(controller, item);

                flowLayoutPanel1.Controls.Add(chart);
            }

            cntMessage = cntMsg;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controller.Model.SendMessage(controller.CurrentChat, textBox1.Text);

            textBox1.Text = string.Empty;
        }
    }
}

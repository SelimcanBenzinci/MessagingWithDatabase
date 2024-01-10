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
        private bool isNotificationShown = false;
        private DateTime? lastNotificationTime = null;
        private TimeSpan notificationCooldown = TimeSpan.FromSeconds(3);
        private PictureBox zilPictureBox;
        private PictureBox[]? emojiPictureBoxes;
        private PictureBox[]? stickerPictureBoxes;
        public Controller controller { get; set; }

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        private int cntMessage = 0;

        public bool bGroupMenu = false;

        public ChatMenu()
        {
            InitializeComponent();

            flowLayoutPanel2.Visible = true;


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
            //bildirim
            if (cntMessage < cntMsg)
            {
                HandleNewMessages();
            }
            else
            {
                isNotificationShown = false;
            }
            cntMessage = cntMsg;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controller.Model.SendMessage(controller.CurrentChat, textBox1.Text);

            textBox1.Text = string.Empty;
        }
        //emoji
        private void button2_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = !flowLayoutPanel2.Visible;

        }


        //bildirim
        private void ShowMessageReceivedNotification(User sender, string messageText)
        {
            DateTime currentTime = DateTime.Now;

            if (isNotificationShown || (lastNotificationTime.HasValue && (currentTime - lastNotificationTime.Value).TotalSeconds < notificationCooldown.TotalSeconds))
            {
                return;
            }
            isNotificationShown = true;
            lastNotificationTime = currentTime;

            Panel notificationPanel = new Panel();
            notificationPanel.BackColor = Color.FromArgb(255, 130, 130, 130);

            Label lblGonderen = new Label();
            lblGonderen.Text = $"Gönderen: {sender.Name}";
            lblGonderen.Location = new Point(10, 30);

            Label lblMesaj = new Label();
            lblMesaj.Text = $"Mesaj: {messageText}";
            lblMesaj.Location = new Point(10, 60);

            PictureBox zil = new PictureBox();
            zil.Click += (s, e) => notificationPanel.Visible = !notificationPanel.Visible;
            zil.Visible = true;

            notificationPanel.Controls.Add(lblGonderen);
            notificationPanel.Controls.Add(lblMesaj);
            notificationPanel.Location = new Point(340, 40);

            zilPictureBox = new PictureBox();
            zilPictureBox.Image = Properties.Resources.bildirim;
            zilPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            zilPictureBox.Click += (s, e) => notificationPanel.Visible = !notificationPanel.Visible;
            Controls.Add(zilPictureBox);
            Controls.Add(notificationPanel);
            zilPictureBox.Width = 46;
            zilPictureBox.Height = 36;
            zilPictureBox.Location = new Point(490, 3);
        }
        private void HandleNewMessages()

        {
            Refresh();
            var lastMessage = controller.Model.GetMessages(controller.CurrentUser, controller.CurrentUser).LastOrDefault();

            if (lastMessage != null && lastMessage.ReceiverUserID == controller.CurrentUser.Id && !isNotificationShown)
            {
                User sender = controller.Model.Users.FirstOrDefault(u => u.Id == lastMessage.SenderUserID);

                ShowMessageReceivedNotification(sender, lastMessage.MessageText);

                isNotificationShown = true;

            }
        }
        private void button26_Click(object sender, EventArgs e)
        {

            string metin = textBox1.Text;

            metin += " 😅";

            textBox1.Text = metin;
        }

        private void button27_Click(object sender, EventArgs e)
        {

            string metin = textBox1.Text;

            metin += " 😎";

            textBox1.Text = metin;
        }

        private void button28_Click(object sender, EventArgs e)
        {

            string metin = textBox1.Text;

            metin += " 😍";

            textBox1.Text = metin;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😡";

            textBox1.Text = metin;
        }

        private void button30_Click(object sender, EventArgs e)
        {

            string metin = textBox1.Text;

            metin += " 😃";

            textBox1.Text = metin;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😱";

            textBox1.Text = metin;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 🤣";

            textBox1.Text = metin;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😏";

            textBox1.Text = metin;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😊";

            textBox1.Text = metin;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 🤩";

            textBox1.Text = metin;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😄";

            textBox1.Text = metin;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😦";

            textBox1.Text = metin;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 🥰";

            textBox1.Text = metin;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😔";

            textBox1.Text = metin;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 🤬";

            textBox1.Text = metin;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 🤗";

            textBox1.Text = metin;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😈";

            textBox1.Text = metin;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😇";

            textBox1.Text = metin;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            metin += " 😋";

            textBox1.Text = metin;
        }
    }
}

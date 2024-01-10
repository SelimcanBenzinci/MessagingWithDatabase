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
            InitializePictureBoxes();
            InitializePictureBoxes1();
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = false;

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
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel3.Visible = false;
        }

        private void InitializePictureBoxes()
        {
            emojiPictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4,pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14
            ,pictureBox15,pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24,pictureBox25,pictureBox26};

            foreach (PictureBox pictureBox in emojiPictureBoxes)
            {
                if (pictureBox != null)
                {
                    pictureBox.Click += EmojiPictureBox_Click;
                    pictureBox.Enabled = true;
                }
            }
        }
        private void EmojiPictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox && clickedPictureBox.Image != null)
            {
                Clipboard.SetImage(clickedPictureBox.Image);
                textBox1.Paste();
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
        }

        //sticker
        private void button3_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = true;
            flowLayoutPanel2.Visible = false;
        }
        private void InitializePictureBoxes1()
        {
            stickerPictureBoxes = new PictureBox[] { pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33 };

            foreach (PictureBox pictureBox in stickerPictureBoxes)
            {
                if (pictureBox != null)
                {
                    pictureBox.Click += StickerPictureBox_Click;
                    pictureBox.Enabled = true;
                }
            }
        }
        private void StickerPictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox && clickedPictureBox.Image != null)
            {
                Clipboard.SetImage(clickedPictureBox.Image);
                textBox1.Paste();
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
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




    }
}

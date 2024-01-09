﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingWithDatabase.UserControls
{
    public partial class AddUser : UserControl
    {

        public Controller controller { get; set; }
        public User user { get; set; }

        public AddUser()
        {
            InitializeComponent();
        }
        public AddUser(Controller cnrl, User usr)
        {
            InitializeComponent();
            controller = cnrl;
            user = usr;

            NameLabel.Text = user.Name;
            StatusLabel.Text = user.Status;
            byte[] ImageByteArray = user.ImageByteArray;

            if (ImageByteArray.Length != 0)
            {
                MemoryStream mem = new MemoryStream(ImageByteArray);
                pictureBox1.Image = Image.FromStream(mem);

                var imageSize = pictureBox1.Image.Size;
                var fitSize = pictureBox1.ClientSize;
                pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            controller.CurrentUser.FriendIDs.Add(user.Id.GetValueOrDefault());
            controller.Model.UpdateUser(user);
        }
    }
}

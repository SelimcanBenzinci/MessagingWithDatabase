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
            byte[] ImageByteArray = new byte[0];

            switch (usr.visibilty)
            {
                case User.Visibilty.Herkes:
                    NameLabel.Text = user.Name;
                    StatusLabel.Text = user.Status;
                    ImageByteArray = user.ImageByteArray;
                    break;
                case User.Visibilty.Hickimse:
                    NameLabel.Text = "Profil Gizli";
                    StatusLabel.Text = "";
                    break;
                default:
                    break;
            }

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
            Friend friend = new Friend()
            { 
                UserID = controller.CurrentUser.Id.GetValueOrDefault(),
                FriendId = user.Id.GetValueOrDefault(),
            };

            controller.CurrentUser.FriendIDs.Add(friend);

            controller.Model.AddFriend(friend);

            controller.Model.UpdateUser(controller.CurrentUser);

            this.Parent.Controls.Remove(this);

            controller.populateChatBoxs(controller.Model.GetChatBoxs());
        }
    }
}

using Microsoft.IdentityModel.Tokens;
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
    public partial class CreateGroup : UserControl
    {

        public Controller controller { get; set; }

        public string ImageDir { get; set; }

        public CreateGroup()
        {
            InitializeComponent();
        }

        public CreateGroup(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;

            List<User> users = new List<User>();
            users.AddRange(controller.Model.GetUsers());

            foreach (User user in users)
            {
                if (user == controller.CurrentUser)
                    continue;
                UserCharBasicList basicUser = new UserCharBasicList(controller, user);

                flowLayoutPanel1.Controls.Add(basicUser);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            byte[] imageN = new byte[0];
            if (!ImageDir.IsNullOrEmpty())
            {
                imageN = File.ReadAllBytes(ImageDir);
            }

            controller.GroupUsers.Add(controller.CurrentUser);
            Group group = new Group()
            {
                GroupID = null,
                Name = NameText.Text,
                Description = DescText.Text,
                ImageByteArray = imageN,
                GroupUsers = controller.GroupUsers,
                GroupAdmin = controller.CurrentUser,
                CreationTime = DateTime.Now,
            };

            controller.Model.AddGroup(group);
            controller.populateChatBoxs(controller.Model.GetChatBoxs());
            controller.populateChat(group);
            controller.GroupUsers = new List<User>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // masaüstünü göstermesi için
            openFileDialog1.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";        // dosya filtrelemesi
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = null;

                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string s in openFileDialog1.FileNames)
                            {
                                ImageDir = s;
                                byte[] ImageByteArray = File.ReadAllBytes(s);
                                MemoryStream mem = new MemoryStream(ImageByteArray);
                                PictureBox.Image = Image.FromStream(mem);
                                var imageSize = PictureBox.Image.Size;
                                var fitSize = PictureBox.ClientSize;
                                PictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                                    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya okunamadı!" + ex.Message);
                }
            }
        }
    }
}

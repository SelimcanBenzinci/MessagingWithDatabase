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
    public partial class ChatChart : UserControl
    {

        public Controller controller { get; set; }
        public IChatBox TargetChat { get; set; }

        public ChatChart()
        {
            InitializeComponent();
        }

        public ChatChart(Controller cntrl, IChatBox chatBox)
        {
            InitializeComponent();
            controller = cntrl;
            TargetChat = chatBox;
            byte[] ImageByteArray = new byte[0];

            var gg = chatBox.GetVisbilty();

            switch (gg)
            {
                case User.Visibilty.Herkes:
                    button1.Text = chatBox.GetName();
                    statusLabel.Text = chatBox.GetLastMessage();
                    ImageByteArray = chatBox.GetImage();
                    break;
                case User.Visibilty.Ekli:
                    button1.Text = chatBox.GetName();
                    statusLabel.Text = chatBox.GetLastMessage();
                    ImageByteArray = chatBox.GetImage();
                    break;
                case User.Visibilty.Hickimse:
                    button1.Text = chatBox.GetName();
                    statusLabel.Text = "Profil Gizli";
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


        private void button1_Click(object sender, EventArgs e)
        {
            controller.populateChat(TargetChat);
        }
    }
}

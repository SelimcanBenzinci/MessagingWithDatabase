using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingWithDatabase
{
    public partial class AccountSetting : UserControl
    {
        //yorum satırı
        public Controller controller { get; set; }

        public string imageDir { get; set; }

        public AccountSetting()
        {
            InitializeComponent();
        }

        public AccountSetting(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;

            NameText.Text = controller.CurrentUser.Name;
            StatusText.Text = controller.CurrentUser.Status;
            visiblityText.Items.Add("Herkes");
            visiblityText.Items.Add("Ekli");
            visiblityText.Items.Add("Hiçkimse");
            visiblityText.SetSelected(((int)controller.CurrentUser.visibilty), true);

            if (controller.CurrentUser.ImageByteArray.Length != 0)
            {
                MemoryStream mem = new MemoryStream(controller.CurrentUser.ImageByteArray);
                PictureBox.Image = Image.FromStream(mem);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            controller.CurrentUser.Name = NameText.Text;
            controller.CurrentUser.Status = StatusText.Text;
            controller.CurrentUser.visibilty = (User.Visibilty)visiblityText.SelectedIndex;
            if (imageDir != "")
            {
                controller.CurrentUser.ImageByteArray = File.ReadAllBytes(imageDir);
            }

            controller.Model.UpdateUser(controller.CurrentUser);
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
                            foreach (string s in openFileDialog1.FileNames)     // multi select özelliği için kullanılabilir
                            {
                                imageDir = s;
                                byte[] ImageByteArray = File.ReadAllBytes(s);
                                MemoryStream mem = new MemoryStream(ImageByteArray);
                                PictureBox.Image = Image.FromStream(mem);
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

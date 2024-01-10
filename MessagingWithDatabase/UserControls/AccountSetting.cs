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

                var imageSize = PictureBox.Image.Size;
                var fitSize = PictureBox.ClientSize;
                PictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            controller.CurrentUser.Name = NameText.Text;
            controller.CurrentUser.Status = StatusText.Text;
            controller.CurrentUser.visibilty = (User.Visibilty)visiblityText.SelectedIndex;

            if (!string.IsNullOrEmpty(imageDir))
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
                            foreach (string s in openFileDialog1.FileNames)
                            {
                                imageDir = s;
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




        private Bitmap CropToContent(Bitmap oldBmp)
        {
            Rectangle currentRect = new Rectangle();
            bool IsFirstOne = true;

            // Get a base color

            for (int y = 0; y < oldBmp.Height; y++)
            {
                for (int x = 0; x < oldBmp.Width; x++)
                {
                    Color debug = oldBmp.GetPixel(x, y);
                    if (oldBmp.GetPixel(x, y) != Color.FromArgb(255, 255, 255, 255))
                    {
                        // We need to interpret this!

                        // Check if it is the first one!

                        if (IsFirstOne)
                        {
                            currentRect.X = x;
                            currentRect.Y = y;
                            currentRect.Width = 1;
                            currentRect.Height = 1;
                            IsFirstOne = false;
                        }
                        else
                        {

                            if (!currentRect.Contains(new Point(x, y)))
                            {
                                // This will run if this is out of the current rectangle

                                if (x > (currentRect.X + currentRect.Width)) currentRect.Width = x - currentRect.X;
                                if (x < (currentRect.X))
                                {
                                    // Move the rectangle over there and extend its width to make the right the same!
                                    int oldRectLeft = currentRect.Left;

                                    currentRect.X = x;
                                    currentRect.Width += oldRectLeft - x;
                                }

                                if (y > (currentRect.Y + currentRect.Height)) currentRect.Height = y - currentRect.Y;

                                if (y < (currentRect.Y + currentRect.Height))
                                {
                                    int oldRectTop = currentRect.Top;

                                    currentRect.Y = y;
                                    currentRect.Height += oldRectTop - y;
                                }
                            }
                        }
                    }
                }
            }

            return CropImage(oldBmp, currentRect.X, currentRect.Y, currentRect.Width, currentRect.Height);
        }

        private Bitmap CropImage(Bitmap source, int x, int y, int width, int height)
        {
            Rectangle cropRect = new Rectangle(x, y, width, height);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(source, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }

            return target;
        }
    }
}

namespace MessagingWithDatabase
{
    partial class Register
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MailText = new TextBox();
            PasswordText = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MailText
            // 
            MailText.BackColor = SystemColors.Info;
            MailText.Location = new Point(307, 63);
            MailText.Name = "MailText";
            MailText.Size = new Size(180, 27);
            MailText.TabIndex = 0;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.Info;
            PasswordText.Location = new Point(307, 119);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(180, 27);
            PasswordText.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(307, 165);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(249, 66);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 3;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(249, 119);
            label2.Name = "label2";
            label2.Size = new Size(41, 22);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_10_09_at_13_18_18_8d9e8ad9_ico;
            pictureBox1.Location = new Point(28, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(307, 19);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 6;
            label3.Text = "Kayıt Ol";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(PasswordText);
            Controls.Add(MailText);
            Name = "Register";
            Size = new Size(523, 260);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MailText;
        private TextBox PasswordText;
        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}

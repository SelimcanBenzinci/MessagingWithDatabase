namespace MessagingWithDatabase
{
    partial class AccountSetting
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameText = new TextBox();
            StatusText = new TextBox();
            visiblityText = new ListBox();
            PictureBox = new PictureBox();
            button1 = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(44, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(44, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 1;
            label2.Text = "Durum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(44, 134);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 2;
            label3.Text = "Gizlilik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(49, 223);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 3;
            label4.Text = "Resim";
            // 
            // NameText
            // 
            NameText.BackColor = SystemColors.Info;
            NameText.Location = new Point(151, 50);
            NameText.Name = "NameText";
            NameText.Size = new Size(217, 27);
            NameText.TabIndex = 4;
            // 
            // StatusText
            // 
            StatusText.BackColor = SystemColors.Info;
            StatusText.Location = new Point(151, 91);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(217, 27);
            StatusText.TabIndex = 5;
            // 
            // visiblityText
            // 
            visiblityText.BackColor = SystemColors.Info;
            visiblityText.FormattingEnabled = true;
            visiblityText.ItemHeight = 20;
            visiblityText.Location = new Point(151, 130);
            visiblityText.Name = "visiblityText";
            visiblityText.Size = new Size(217, 64);
            visiblityText.TabIndex = 7;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(151, 252);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(100, 100);
            PictureBox.TabIndex = 8;
            PictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(151, 214);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Yükle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(274, 352);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AccountSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(SaveButton);
            Controls.Add(button1);
            Controls.Add(PictureBox);
            Controls.Add(visiblityText);
            Controls.Add(StatusText);
            Controls.Add(NameText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountSetting";
            Size = new Size(390, 394);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameText;
        private TextBox StatusText;
        private ListBox visiblityText;
        private PictureBox PictureBox;
        private Button button1;
        private Button SaveButton;
    }
}

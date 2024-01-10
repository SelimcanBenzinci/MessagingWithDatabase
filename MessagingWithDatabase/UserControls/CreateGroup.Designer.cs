namespace MessagingWithDatabase
{
    partial class CreateGroup
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
            SaveButton = new Button();
            button1 = new Button();
            PictureBox = new PictureBox();
            DescText = new TextBox();
            NameText = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(304, 217);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(107, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Yükle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(107, 146);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(100, 100);
            PictureBox.TabIndex = 18;
            PictureBox.TabStop = false;
            // 
            // DescText
            // 
            DescText.BackColor = SystemColors.Info;
            DescText.Location = new Point(107, 63);
            DescText.Name = "DescText";
            DescText.Size = new Size(160, 27);
            DescText.TabIndex = 16;
            // 
            // NameText
            // 
            NameText.BackColor = SystemColors.Info;
            NameText.Location = new Point(107, 22);
            NameText.Name = "NameText";
            NameText.Size = new Size(160, 27);
            NameText.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(29, 111);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 14;
            label4.Text = "Resim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 12;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 11;
            label1.Text = "Grup İsmi";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(17, 252);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 188);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // CreateGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SaveButton);
            Controls.Add(button1);
            Controls.Add(PictureBox);
            Controls.Add(DescText);
            Controls.Add(NameText);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateGroup";
            Size = new Size(414, 484);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Button button1;
        private PictureBox PictureBox;
        private TextBox DescText;
        private TextBox NameText;
        private Label label4;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

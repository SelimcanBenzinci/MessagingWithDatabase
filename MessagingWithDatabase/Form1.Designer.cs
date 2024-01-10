namespace MessagingWithDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AccountButton = new Button();
            CreateGroupButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(379, 66);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 595);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(50, 27);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(278, 374);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // AccountButton
            // 
            AccountButton.Location = new Point(606, 667);
            AccountButton.Margin = new Padding(3, 2, 3, 2);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(104, 29);
            AccountButton.TabIndex = 2;
            AccountButton.Text = "Hesap Ayarları";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Visible = false;
            AccountButton.Click += AccountButton_Click;
            // 
            // CreateGroupButton
            // 
            CreateGroupButton.Location = new Point(493, 666);
            CreateGroupButton.Margin = new Padding(3, 2, 3, 2);
            CreateGroupButton.Name = "CreateGroupButton";
            CreateGroupButton.Size = new Size(107, 29);
            CreateGroupButton.TabIndex = 3;
            CreateGroupButton.Text = "Grup Oluştur";
            CreateGroupButton.UseVisualStyleBackColor = true;
            CreateGroupButton.Visible = false;
            CreateGroupButton.Click += CreateGroupButton_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(433, 571);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(102, 39);
            button1.TabIndex = 4;
            button1.Text = "Kişi Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1010, 625);
            Controls.Add(button1);
            Controls.Add(CreateGroupButton);
            Controls.Add(AccountButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public FlowLayoutPanel flowLayoutPanel1;
        public Button AccountButton;
        public Button CreateGroupButton;
        private Button button1;
    }
}
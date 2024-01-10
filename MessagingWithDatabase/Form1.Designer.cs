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
            panel1.Location = new Point(332, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 446);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(44, 20);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(243, 280);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // AccountButton
            // 
            AccountButton.Location = new Point(530, 500);
            AccountButton.Margin = new Padding(3, 2, 3, 2);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(91, 22);
            AccountButton.TabIndex = 2;
            AccountButton.Text = "Hesap Ayarları";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Visible = false;
            AccountButton.Click += AccountButton_Click;
            // 
            // CreateGroupButton
            // 
            CreateGroupButton.Location = new Point(431, 500);
            CreateGroupButton.Margin = new Padding(3, 2, 3, 2);
            CreateGroupButton.Name = "CreateGroupButton";
            CreateGroupButton.Size = new Size(94, 22);
            CreateGroupButton.TabIndex = 3;
            CreateGroupButton.Text = "Grup Oluştur";
            CreateGroupButton.UseVisualStyleBackColor = true;
            CreateGroupButton.Visible = false;
            CreateGroupButton.Click += CreateGroupButton_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(379, 667);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 4;
            button1.Text = "Kişi Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1010, 625);
            Controls.Add(button1);
            Controls.Add(CreateGroupButton);
            Controls.Add(AccountButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
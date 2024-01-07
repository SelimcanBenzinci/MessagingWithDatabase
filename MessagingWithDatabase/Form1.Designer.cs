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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(433, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 431);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(57, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(318, 498);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // AccountButton
            // 
            AccountButton.Location = new Point(807, 584);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(219, 29);
            AccountButton.TabIndex = 2;
            AccountButton.Text = "Hesap Ayarları";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Visible = false;
            AccountButton.Click += button1_Click;
            // 
            // CreateGroupButton
            // 
            CreateGroupButton.Location = new Point(433, 584);
            CreateGroupButton.Name = "CreateGroupButton";
            CreateGroupButton.Size = new Size(208, 29);
            CreateGroupButton.TabIndex = 3;
            CreateGroupButton.Text = "Grup Oluştur";
            CreateGroupButton.UseVisualStyleBackColor = true;
            CreateGroupButton.Visible = false;
            CreateGroupButton.Click += CreateGroupButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 625);
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
    }
}
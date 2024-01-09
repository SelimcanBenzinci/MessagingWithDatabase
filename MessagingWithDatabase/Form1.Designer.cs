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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountButton = new System.Windows.Forms.Button();
            this.CreateGroupButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(379, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 323);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 27);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 374);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(794, 431);
            this.AccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(104, 29);
            this.AccountButton.TabIndex = 2;
            this.AccountButton.Text = "Hesap Ayarları";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Visible = false;
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.Location = new System.Drawing.Point(668, 431);
            this.CreateGroupButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(107, 29);
            this.CreateGroupButton.TabIndex = 3;
            this.CreateGroupButton.Text = "Grup Oluştur";
            this.CreateGroupButton.UseVisualStyleBackColor = true;
            this.CreateGroupButton.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kişi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateGroupButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panel1;
        public FlowLayoutPanel flowLayoutPanel1;
        public Button AccountButton;
        public Button CreateGroupButton;
        private Button button1;
    }
}
namespace MessagingWithDatabase
{
    partial class Login
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
            Kaydol = new Button();
            SuspendLayout();
            // 
            // MailText
            // 
            MailText.Location = new Point(280, 65);
            MailText.Name = "MailText";
            MailText.Size = new Size(125, 27);
            MailText.TabIndex = 0;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(280, 119);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(125, 27);
            PasswordText.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(297, 178);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 227);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // Kaydol
            // 
            Kaydol.Location = new Point(26, 223);
            Kaydol.Name = "Kaydol";
            Kaydol.Size = new Size(94, 29);
            Kaydol.TabIndex = 4;
            Kaydol.Text = "Kaydol";
            Kaydol.UseVisualStyleBackColor = true;
            Kaydol.Click += Kaydol_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Kaydol);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(PasswordText);
            Controls.Add(MailText);
            Name = "Login";
            Size = new Size(505, 266);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MailText;
        private TextBox PasswordText;
        private Button button1;
        private Label label1;
        private Button Kaydol;
    }
}

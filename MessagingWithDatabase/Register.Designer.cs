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
            NameText = new TextBox();
            PasswordText = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.Location = new Point(280, 39);
            NameText.Name = "NameText";
            NameText.Size = new Size(125, 27);
            NameText.TabIndex = 0;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(280, 87);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(125, 27);
            PasswordText.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(292, 139);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(PasswordText);
            Controls.Add(NameText);
            Name = "Register";
            Size = new Size(579, 201);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameText;
        private TextBox PasswordText;
        private Button button1;
    }
}

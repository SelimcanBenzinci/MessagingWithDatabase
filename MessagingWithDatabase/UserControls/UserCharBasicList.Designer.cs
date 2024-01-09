namespace MessagingWithDatabase
{
    partial class UserCharBasicList
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
            AddUserButton = new Button();
            SuspendLayout();
            // 
            // AddUserButton
            // 
            AddUserButton.BackColor = Color.Snow;
            AddUserButton.Location = new Point(5, 2);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(177, 32);
            AddUserButton.TabIndex = 0;
            AddUserButton.Text = "button1";
            AddUserButton.UseVisualStyleBackColor = false;
            AddUserButton.Click += button1_Click;
            // 
            // UserCharBasicList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddUserButton);
            Name = "UserCharBasicList";
            Size = new Size(186, 37);
            ResumeLayout(false);
        }

        #endregion

        public Button AddUserButton;
    }
}

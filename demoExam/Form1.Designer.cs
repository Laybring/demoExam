namespace demoExam
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
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            AuthButton = new Button();
            RegButton = new Button();
            GuestButton = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 48);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(266, 23);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 106);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(266, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(12, 176);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(266, 23);
            AuthButton.TabIndex = 2;
            AuthButton.Text = "Авторизоваться";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(12, 205);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(266, 23);
            RegButton.TabIndex = 3;
            RegButton.Text = "Зарегистрироваться";
            RegButton.UseVisualStyleBackColor = true;
            // 
            // GuestButton
            // 
            GuestButton.Location = new Point(12, 234);
            GuestButton.Name = "GuestButton";
            GuestButton.Size = new Size(266, 23);
            GuestButton.TabIndex = 4;
            GuestButton.Text = "Гостевой режим";
            GuestButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 266);
            Controls.Add(GuestButton);
            Controls.Add(RegButton);
            Controls.Add(AuthButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button AuthButton;
        private Button RegButton;
        private Button GuestButton;
    }
}
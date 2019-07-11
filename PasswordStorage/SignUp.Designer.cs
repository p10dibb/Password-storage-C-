namespace PasswordStorage
{
    partial class SignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(113, 350);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(289, 37);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_ClickAsync);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(113, 74);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.ReadOnly = true;
            this.FirstNameText.Size = new System.Drawing.Size(123, 22);
            this.FirstNameText.TabIndex = 2;
            this.FirstNameText.Text = "First Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(123, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "User Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(123, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Email";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(113, 253);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(123, 22);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Password";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(113, 298);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(123, 22);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Confirm Password";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(304, 74);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(248, 22);
            this.FirstName.TabIndex = 8;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(304, 113);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(248, 22);
            this.LastName.TabIndex = 9;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(304, 159);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(248, 22);
            this.UserName.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(304, 202);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(248, 22);
            this.Email.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(304, 252);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(248, 22);
            this.Password.TabIndex = 12;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(304, 298);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(248, 22);
            this.ConfirmPassword.TabIndex = 13;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 415);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.Back);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmPassword;
    }
}
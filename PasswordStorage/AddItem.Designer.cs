namespace PasswordStorage
{
    partial class AddItem
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Website";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Password";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(220, 12);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(224, 22);
            this.Name.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(220, 173);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(224, 22);
            this.Password.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(51, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(120, 22);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "confirm Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(220, 216);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(224, 22);
            this.ConfirmPassword.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(51, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(120, 22);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "email used";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(220, 91);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(224, 22);
            this.Email.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(51, 49);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(120, 22);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "URL";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(220, 50);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(224, 22);
            this.URL.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Username";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(220, 133);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(224, 22);
            this.UserName.TabIndex = 12;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 345);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            //this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox UserName;
    }
}
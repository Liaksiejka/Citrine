namespace Admin
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.loginLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(539, 73);
			this.label1.TabIndex = 3;
			this.label1.Text = "Добро пожаловать!\r\n\r\nДля входа в систему введите данные в поля ниже и нажмите Вой" +
			"ти.\r\nПосле входа появиться возможность создать или отредактировать тест. ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(230, 180);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(99, 30);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "Войти";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.LoginBtnClick);
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(278, 102);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(207, 22);
			this.loginBox.TabIndex = 0;
			// 
			// loginLabel
			// 
			this.loginLabel.Location = new System.Drawing.Point(100, 101);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(172, 23);
			this.loginLabel.TabIndex = 4;
			this.loginLabel.Text = "Имя пользователя";
			// 
			// passwordLabel
			// 
			this.passwordLabel.Location = new System.Drawing.Point(100, 138);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(100, 23);
			this.passwordLabel.TabIndex = 5;
			this.passwordLabel.Text = "Пароль";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(278, 139);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(207, 22);
			this.passwordBox.TabIndex = 1;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 222);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход в систему - Citrine";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label label1;
	}
}

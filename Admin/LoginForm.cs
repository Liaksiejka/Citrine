using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Admin
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			#if DEBUG
			loginBox.Text = "admin";
			passwordBox.Text = "admin";
			#endif
		}
		
		void LoginBtnClick(object sender, EventArgs e)
		{
			if ((loginBox.Text == "admin") && (passwordBox.Text == "admin")) {
				Thread t = new Thread(new ThreadStart(ChoiceFormThread));
				t.SetApartmentState(ApartmentState.STA);
				t.Start();
				this.Close();
			} else {
				MessageBox.Show("Имя пользователя или пароль введены не верно. " +
				                "\n\nПожалуйста попробуйте ещё раз.","Ошибка");
			}
		}
		
		[STAThread]
		private static void ChoiceFormThread()
		{
			ChoiceForm f = new ChoiceForm();
			Application.Run(f);
		}
	}
}

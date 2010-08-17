using System;
using System.Drawing;
using System.Windows.Forms;
using TestClasses;

namespace Admin
{
	/// <summary>
	/// Description of ChoiceForm.
	/// </summary>
	public partial class ChoiceForm : Form
	{
		public ChoiceForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TestSuite ts = new TestSuite();
			ts.name = "test name";
			ts.Write("f:\\test.xml");
			
			TestSuite ts2 = TestSuite.Read("f:\\test.xml");
			MessageBox.Show(ts2.name.ToString());
		}
	}
}

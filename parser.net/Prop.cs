using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parser.net
{
	public partial class Prop : Form
	{
		public Prop()
		{
			InitializeComponent();
			KeyTextBox.Text = Properties.Settings.Default.AppKey;
			IdTextBox.Text = Properties.Settings.Default.AppId;
			withPhotoRB.Checked = Properties.Settings.Default.withPhoto;
			withoutPhotoRB.Checked = !Properties.Settings.Default.withPhoto;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.AppKey = KeyTextBox.Text;
			Properties.Settings.Default.AppId = IdTextBox.Text;
			Properties.Settings.Default.withPhoto = withPhotoRB.Checked;
			Properties.Settings.Default.Save();
			this.Close();
		}
	}
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VkNet;
using VkNet.Model;


namespace parser.net
{
    public partial class mainForm : Form
    {
        private OpenFileDialog OpenDialog = new OpenFileDialog();
		private SaveFileDialog SaveDialog = new SaveFileDialog();
		private VkApi api = new VkApi();
		Check check;
        public mainForm()
        {
            InitializeComponent();
            OpenDialog.FileOk += OpenDialogOk;
            OpenDialog.Multiselect = false;
			SaveDialog.FileOk += SaveDialogOk;
			api.Authorize(new ApiAuthParams
			{
				AccessToken = Properties.Settings.Default.AppKey
			});
			if (Properties.Settings.Default.withPhoto)
				check = new CheckWithPhoto();
			else
				check = new CheckWithoutPhoto();
		}
        
        private void UploadButton_Click(object sender, EventArgs e)
        {            
            OpenDialog.ShowDialog();
        }

		private void SaveDialogOk(object sender, EventArgs e){
			System.IO.Stream s = null;
			try
			{
				if ((s = SaveDialog.OpenFile()) != null)
				{
					using (StreamWriter writer = new StreamWriter(s, Encoding.UTF8))
					{
						writer.Write(OutputTextBox.Text);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

        private void OpenDialogOk(object sender, EventArgs e)
        {
			System.IO.Stream s = null;
            try
            {
				if((s = OpenDialog.OpenFile())!= null){
					using (StreamReader reader = new StreamReader(s, Encoding.UTF8)){
						InputTextBox.Text = reader.ReadToEnd();
						reader.Close();
					}
				}
            }
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
        }

		private int FillOutTextBox(string[] ids) {
			try
			{
				//var res = api.Groups.GetById(ids, null, VkNet.Enums.Filters.GroupsFields.Activity);
				List<Group> res = new List<Group>();
				Dictionary<string, string> d = new Dictionary<string, string>();

				d.Add("group_ids", String.Join(",", ids));
				d.Add("fields", "cover");
				VkNet.Utils.VkParameters param = new VkNet.Utils.VkParameters(d);
				VkNet.Utils.VkResponseArray v = api.Call("groups.getById", param);
				
				foreach(var g in v){
					res.Add(VkNet.Model.Group.FromJson(g));
				}

				foreach (var g in res)
				{
					//if (g.Photo50.LocalPath == "/images/community_50.png")
						if (check.CheckGroup(g))
						{
							OutputTextBox.Text += g.Id.ToString() + "\r\n";
						}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Неверный сервисный ключ доступа.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
			return 1;
		}

		private void LockProgram() {
			UploadButton.Enabled = false;
			SaveButton.Enabled = false;
		}

		private void UnlockProgram() {
			UploadButton.Enabled = true;
			SaveButton.Enabled = true;
		}

		private void ProcessingButton_Click(object sender, EventArgs e)
		{
			OutputTextBox.Text = "";
			char[] separator = { '\r', '\n' };
			string[] ids = InputTextBox.Text.Split(separator,StringSplitOptions.RemoveEmptyEntries);

			LockProgram();
			
			while(true){
				if(ids.Length < 500){
					if (FillOutTextBox(ids) == 0)
					{
						UnlockProgram();
						return;
					}
					break;
				}
				else{
					string[] tmp = new string[500];
					Array.Copy(ids, ids.Length - 500, tmp, 0, 500);
					Array.Resize(ref ids, ids.Length - 500);
					if (FillOutTextBox(tmp) == 0)
					{
						UnlockProgram();
						return;
					}
					break;
				}
			}
			UnlockProgram();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			SaveDialog.ShowDialog();
		}

		private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Prop p = new Prop();
			string id = Properties.Settings.Default.AppKey;
			bool withPhoto = Properties.Settings.Default.withPhoto;
			p.ShowDialog();
			if(id != Properties.Settings.Default.AppKey){
				api.Authorize(new ApiAuthParams
				{
					AccessToken = Properties.Settings.Default.AppKey
				});
			}
			if (withPhoto != Properties.Settings.Default.withPhoto)
				if (Properties.Settings.Default.withPhoto)
					check = new CheckWithPhoto();
				else
					check = new CheckWithoutPhoto();
		}
	}
}

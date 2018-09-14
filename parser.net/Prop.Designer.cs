namespace parser.net
{
	partial class Prop
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
			this.KeyTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.IdTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.withPhotoRB = new System.Windows.Forms.RadioButton();
			this.withoutPhotoRB = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// KeyTextBox
			// 
			this.KeyTextBox.Location = new System.Drawing.Point(189, 35);
			this.KeyTextBox.Name = "KeyTextBox";
			this.KeyTextBox.Size = new System.Drawing.Size(331, 20);
			this.KeyTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Сервисный ключ доступа";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(102, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Id приложения";
			// 
			// IdTextBox
			// 
			this.IdTextBox.Location = new System.Drawing.Point(189, 70);
			this.IdTextBox.Name = "IdTextBox";
			this.IdTextBox.Size = new System.Drawing.Size(331, 20);
			this.IdTextBox.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(445, 157);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 157);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Выводить id групп";
			// 
			// withPhotoRB
			// 
			this.withPhotoRB.AutoSize = true;
			this.withPhotoRB.Location = new System.Drawing.Point(210, 112);
			this.withPhotoRB.Name = "withPhotoRB";
			this.withPhotoRB.Size = new System.Drawing.Size(85, 17);
			this.withPhotoRB.TabIndex = 7;
			this.withPhotoRB.TabStop = true;
			this.withPhotoRB.Text = "С обложкой";
			this.withPhotoRB.UseVisualStyleBackColor = true;
			// 
			// withoutPhotoRB
			// 
			this.withoutPhotoRB.AutoSize = true;
			this.withoutPhotoRB.Location = new System.Drawing.Point(346, 112);
			this.withoutPhotoRB.Name = "withoutPhotoRB";
			this.withoutPhotoRB.Size = new System.Drawing.Size(91, 17);
			this.withoutPhotoRB.TabIndex = 8;
			this.withoutPhotoRB.TabStop = true;
			this.withoutPhotoRB.Text = "Без обложки";
			this.withoutPhotoRB.UseVisualStyleBackColor = true;
			// 
			// Prop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 192);
			this.Controls.Add(this.withoutPhotoRB);
			this.Controls.Add(this.withPhotoRB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.IdTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.KeyTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Prop";
			this.Text = "Настройки";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox KeyTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IdTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton withPhotoRB;
		private System.Windows.Forms.RadioButton withoutPhotoRB;
	}
}
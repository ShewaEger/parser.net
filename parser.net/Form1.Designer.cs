namespace parser.net
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UploadButton = new System.Windows.Forms.Button();
			this.ProcessingButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.OutputTextBox = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Входные данные";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(349, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Выходные данные";
			// 
			// UploadButton
			// 
			this.UploadButton.Location = new System.Drawing.Point(215, 124);
			this.UploadButton.Name = "UploadButton";
			this.UploadButton.Size = new System.Drawing.Size(75, 23);
			this.UploadButton.TabIndex = 4;
			this.UploadButton.Text = "Загрузить";
			this.UploadButton.UseVisualStyleBackColor = true;
			this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
			// 
			// ProcessingButton
			// 
			this.ProcessingButton.Location = new System.Drawing.Point(215, 153);
			this.ProcessingButton.Name = "ProcessingButton";
			this.ProcessingButton.Size = new System.Drawing.Size(75, 23);
			this.ProcessingButton.TabIndex = 5;
			this.ProcessingButton.Text = "Обработать";
			this.ProcessingButton.UseVisualStyleBackColor = true;
			this.ProcessingButton.Click += new System.EventHandler(this.ProcessingButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(215, 182);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(12, 40);
			this.InputTextBox.Multiline = true;
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.InputTextBox.Size = new System.Drawing.Size(150, 309);
			this.InputTextBox.TabIndex = 7;
			// 
			// OutputTextBox
			// 
			this.OutputTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.OutputTextBox.Location = new System.Drawing.Point(352, 40);
			this.OutputTextBox.Multiline = true;
			this.OutputTextBox.Name = "OutputTextBox";
			this.OutputTextBox.ReadOnly = true;
			this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.OutputTextBox.Size = new System.Drawing.Size(150, 309);
			this.OutputTextBox.TabIndex = 8;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(514, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// параметрыToolStripMenuItem
			// 
			this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
			this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.параметрыToolStripMenuItem.Text = "Параметры";
			this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 361);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.OutputTextBox);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ProcessingButton);
			this.Controls.Add(this.UploadButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(530, 400);
			this.MinimumSize = new System.Drawing.Size(530, 370);
			this.Name = "mainForm";
			this.Text = "Парсер";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button ProcessingButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
	}
}


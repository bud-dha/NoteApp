namespace NoteApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.MainFormListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.MainFormTextBox = new System.Windows.Forms.TextBox();
            this.MainFormModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MainFormCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MainFormModifiedLabel = new System.Windows.Forms.Label();
            this.MainFormCreatedLabel = new System.Windows.Forms.Label();
            this.MainFormCurentCategoryLable = new System.Windows.Forms.Label();
            this.MainFormCategoryLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.MainFormListBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainFormTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormModifiedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCreatedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCurentCategoryLable);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.HeadingLabel);
            this.splitContainer1.Size = new System.Drawing.Size(934, 487);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveNoteButton.FlatAppearance.BorderSize = 0;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(83, 445);
            this.RemoveNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveNoteButton.MaximumSize = new System.Drawing.Size(33, 32);
            this.RemoveNoteButton.MinimumSize = new System.Drawing.Size(33, 32);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(33, 32);
            this.RemoveNoteButton.TabIndex = 11;
            this.RemoveNoteButton.UseVisualStyleBackColor = false;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(46, 445);
            this.EditNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditNoteButton.MaximumSize = new System.Drawing.Size(33, 32);
            this.EditNoteButton.MinimumSize = new System.Drawing.Size(33, 32);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(33, 32);
            this.EditNoteButton.TabIndex = 10;
            this.EditNoteButton.UseVisualStyleBackColor = false;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(9, 445);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(33, 32);
            this.AddNoteButton.MinimumSize = new System.Drawing.Size(33, 32);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(33, 32);
            this.AddNoteButton.TabIndex = 9;
            this.AddNoteButton.UseVisualStyleBackColor = false;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // MainFormListBox
            // 
            this.MainFormListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormListBox.FormattingEnabled = true;
            this.MainFormListBox.Location = new System.Drawing.Point(9, 38);
            this.MainFormListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MainFormListBox.Name = "MainFormListBox";
            this.MainFormListBox.Size = new System.Drawing.Size(288, 394);
            this.MainFormListBox.TabIndex = 8;
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCategoryLabel.Location = new System.Drawing.Point(6, 14);
            this.ShowCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(91, 16);
            this.ShowCategoryLabel.TabIndex = 7;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // MainFormTextBox
            // 
            this.MainFormTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTextBox.Location = new System.Drawing.Point(6, 87);
            this.MainFormTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MainFormTextBox.Multiline = true;
            this.MainFormTextBox.Name = "MainFormTextBox";
            this.MainFormTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainFormTextBox.Size = new System.Drawing.Size(609, 390);
            this.MainFormTextBox.TabIndex = 7;
            // 
            // MainFormModifiedDateTimePicker
            // 
            this.MainFormModifiedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainFormModifiedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormModifiedDateTimePicker.Location = new System.Drawing.Point(220, 63);
            this.MainFormModifiedDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.MainFormModifiedDateTimePicker.Name = "MainFormModifiedDateTimePicker";
            this.MainFormModifiedDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.MainFormModifiedDateTimePicker.TabIndex = 6;
            // 
            // MainFormCreatedDateTimePicker
            // 
            this.MainFormCreatedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainFormCreatedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormCreatedDateTimePicker.Location = new System.Drawing.Point(59, 63);
            this.MainFormCreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.MainFormCreatedDateTimePicker.Name = "MainFormCreatedDateTimePicker";
            this.MainFormCreatedDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.MainFormCreatedDateTimePicker.TabIndex = 5;
            // 
            // MainFormModifiedLabel
            // 
            this.MainFormModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormModifiedLabel.AutoSize = true;
            this.MainFormModifiedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormModifiedLabel.Location = new System.Drawing.Point(157, 65);
            this.MainFormModifiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainFormModifiedLabel.Name = "MainFormModifiedLabel";
            this.MainFormModifiedLabel.Size = new System.Drawing.Size(59, 16);
            this.MainFormModifiedLabel.TabIndex = 4;
            this.MainFormModifiedLabel.Text = "Modified:";
            // 
            // MainFormCreatedLabel
            // 
            this.MainFormCreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormCreatedLabel.AutoSize = true;
            this.MainFormCreatedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormCreatedLabel.Location = new System.Drawing.Point(3, 65);
            this.MainFormCreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainFormCreatedLabel.Name = "MainFormCreatedLabel";
            this.MainFormCreatedLabel.Size = new System.Drawing.Size(52, 16);
            this.MainFormCreatedLabel.TabIndex = 3;
            this.MainFormCreatedLabel.Text = "Created:";
            // 
            // MainFormCurentCategoryLable
            // 
            this.MainFormCurentCategoryLable.AutoSize = true;
            this.MainFormCurentCategoryLable.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormCurentCategoryLable.Location = new System.Drawing.Point(57, 38);
            this.MainFormCurentCategoryLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainFormCurentCategoryLable.Name = "MainFormCurentCategoryLable";
            this.MainFormCurentCategoryLable.Size = new System.Drawing.Size(36, 16);
            this.MainFormCurentCategoryLable.TabIndex = 2;
            this.MainFormCurentCategoryLable.Text = "Work";
            // 
            // MainFormCategoryLabel
            // 
            this.MainFormCategoryLabel.AutoSize = true;
            this.MainFormCategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormCategoryLabel.Location = new System.Drawing.Point(3, 38);
            this.MainFormCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainFormCategoryLabel.Name = "MainFormCategoryLabel";
            this.MainFormCategoryLabel.Size = new System.Drawing.Size(59, 16);
            this.MainFormCategoryLabel.TabIndex = 1;
            this.MainFormCategoryLabel.Text = "Category:";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(2, 9);
            this.HeadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(360, 21);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Здесь будет заголовок какой-то заметки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ListBox MainFormListBox;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label MainFormCategoryLabel;
        private System.Windows.Forms.Label MainFormModifiedLabel;
        private System.Windows.Forms.Label MainFormCreatedLabel;
        private System.Windows.Forms.Label MainFormCurentCategoryLable;
        private System.Windows.Forms.TextBox MainFormTextBox;
        private System.Windows.Forms.DateTimePicker MainFormModifiedDateTimePicker;
        private System.Windows.Forms.DateTimePicker MainFormCreatedDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ShowCategoryUpDown = new System.Windows.Forms.DomainUpDown();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.MainFormListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.EditLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.MainFormScrollBar = new System.Windows.Forms.VScrollBar();
            this.MainFormTextBox = new System.Windows.Forms.TextBox();
            this.MainFormModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MainFormCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MainFormModifiedLabel = new System.Windows.Forms.Label();
            this.MainFormCreatedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MainFormCategoryLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 558);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.MainFormListBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.HelpLabel);
            this.splitContainer1.Panel1.Controls.Add(this.EditLabel);
            this.splitContainer1.Panel1.Controls.Add(this.FileLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainFormScrollBar);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormModifiedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCreatedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.MainFormCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.HeadingLabel);
            this.splitContainer1.Size = new System.Drawing.Size(928, 558);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 1;
            // 
            // ShowCategoryUpDown
            // 
            this.ShowCategoryUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryUpDown.Location = new System.Drawing.Point(150, 41);
            this.ShowCategoryUpDown.Name = "ShowCategoryUpDown";
            this.ShowCategoryUpDown.Size = new System.Drawing.Size(135, 26);
            this.ShowCategoryUpDown.TabIndex = 12;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(125, 496);
            this.RemoveNoteButton.MaximumSize = new System.Drawing.Size(50, 50);
            this.RemoveNoteButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(50, 50);
            this.RemoveNoteButton.TabIndex = 11;
            this.RemoveNoteButton.UseVisualStyleBackColor = false;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(69, 496);
            this.EditNoteButton.MaximumSize = new System.Drawing.Size(50, 50);
            this.EditNoteButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(50, 50);
            this.EditNoteButton.TabIndex = 10;
            this.EditNoteButton.UseVisualStyleBackColor = false;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(13, 496);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(50, 50);
            this.AddNoteButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(50, 50);
            this.AddNoteButton.TabIndex = 9;
            this.AddNoteButton.UseVisualStyleBackColor = false;
            this.AddNoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFormListBox
            // 
            this.MainFormListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormListBox.FormattingEnabled = true;
            this.MainFormListBox.ItemHeight = 20;
            this.MainFormListBox.Location = new System.Drawing.Point(13, 73);
            this.MainFormListBox.Name = "MainFormListBox";
            this.MainFormListBox.Size = new System.Drawing.Size(272, 404);
            this.MainFormListBox.TabIndex = 8;
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 42);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(135, 23);
            this.ShowCategoryLabel.TabIndex = 7;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.Location = new System.Drawing.Point(122, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(53, 25);
            this.HelpLabel.TabIndex = 6;
            this.HelpLabel.Text = "Help";
            this.HelpLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLabel.Location = new System.Drawing.Point(70, 9);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(46, 25);
            this.EditLabel.TabIndex = 5;
            this.EditLabel.Text = "Edit";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLabel.Location = new System.Drawing.Point(22, 9);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(42, 25);
            this.FileLabel.TabIndex = 4;
            this.FileLabel.Text = "File";
            // 
            // MainFormScrollBar
            // 
            this.MainFormScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormScrollBar.Location = new System.Drawing.Point(586, 134);
            this.MainFormScrollBar.Name = "MainFormScrollBar";
            this.MainFormScrollBar.Size = new System.Drawing.Size(25, 412);
            this.MainFormScrollBar.TabIndex = 8;
            // 
            // MainFormTextBox
            // 
            this.MainFormTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTextBox.Location = new System.Drawing.Point(9, 134);
            this.MainFormTextBox.Multiline = true;
            this.MainFormTextBox.Name = "MainFormTextBox";
            this.MainFormTextBox.Size = new System.Drawing.Size(576, 412);
            this.MainFormTextBox.TabIndex = 7;
            // 
            // MainFormModifiedDateTimePicker
            // 
            this.MainFormModifiedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainFormModifiedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormModifiedDateTimePicker.Location = new System.Drawing.Point(290, 102);
            this.MainFormModifiedDateTimePicker.Name = "MainFormModifiedDateTimePicker";
            this.MainFormModifiedDateTimePicker.Size = new System.Drawing.Size(126, 26);
            this.MainFormModifiedDateTimePicker.TabIndex = 6;
            // 
            // MainFormCreatedDateTimePicker
            // 
            this.MainFormCreatedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainFormCreatedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormCreatedDateTimePicker.Location = new System.Drawing.Point(76, 102);
            this.MainFormCreatedDateTimePicker.Name = "MainFormCreatedDateTimePicker";
            this.MainFormCreatedDateTimePicker.Size = new System.Drawing.Size(126, 26);
            this.MainFormCreatedDateTimePicker.TabIndex = 5;
            // 
            // MainFormModifiedLabel
            // 
            this.MainFormModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormModifiedLabel.AutoSize = true;
            this.MainFormModifiedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormModifiedLabel.Location = new System.Drawing.Point(208, 105);
            this.MainFormModifiedLabel.Name = "MainFormModifiedLabel";
            this.MainFormModifiedLabel.Size = new System.Drawing.Size(86, 23);
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
            this.MainFormCreatedLabel.Location = new System.Drawing.Point(5, 106);
            this.MainFormCreatedLabel.Name = "MainFormCreatedLabel";
            this.MainFormCreatedLabel.Size = new System.Drawing.Size(75, 23);
            this.MainFormCreatedLabel.TabIndex = 3;
            this.MainFormCreatedLabel.Text = "Created:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Work";
            // 
            // MainFormCategoryLabel
            // 
            this.MainFormCategoryLabel.AutoSize = true;
            this.MainFormCategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormCategoryLabel.Location = new System.Drawing.Point(5, 72);
            this.MainFormCategoryLabel.Name = "MainFormCategoryLabel";
            this.MainFormCategoryLabel.Size = new System.Drawing.Size(86, 23);
            this.MainFormCategoryLabel.TabIndex = 1;
            this.MainFormCategoryLabel.Text = "Category:";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(3, 37);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(526, 31);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Здесь будет заголовок какой-то заметки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(931, 558);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label EditLabel;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.ListBox MainFormListBox;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.DomainUpDown ShowCategoryUpDown;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label MainFormCategoryLabel;
        private System.Windows.Forms.Label MainFormModifiedLabel;
        private System.Windows.Forms.Label MainFormCreatedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.VScrollBar MainFormScrollBar;
        private System.Windows.Forms.TextBox MainFormTextBox;
        private System.Windows.Forms.DateTimePicker MainFormModifiedDateTimePicker;
        private System.Windows.Forms.DateTimePicker MainFormCreatedDateTimePicker;
    }
}


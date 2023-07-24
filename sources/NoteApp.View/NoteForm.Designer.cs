namespace NoteApp.View
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NoteFormCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteFormCreatedLabel = new System.Windows.Forms.Label();
            this.NoteFormModifiedLabel = new System.Windows.Forms.Label();
            this.NoteFormModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.NoteFormTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NoteFormComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(8, 10);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 16);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(8, 37);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(59, 16);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // NoteFormCreatedDateTimePicker
            // 
            this.NoteFormCreatedDateTimePicker.Location = new System.Drawing.Point(63, 63);
            this.NoteFormCreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NoteFormCreatedDateTimePicker.Name = "NoteFormCreatedDateTimePicker";
            this.NoteFormCreatedDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.NoteFormCreatedDateTimePicker.TabIndex = 2;
            // 
            // NoteFormCreatedLabel
            // 
            this.NoteFormCreatedLabel.AutoSize = true;
            this.NoteFormCreatedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteFormCreatedLabel.Location = new System.Drawing.Point(8, 65);
            this.NoteFormCreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteFormCreatedLabel.Name = "NoteFormCreatedLabel";
            this.NoteFormCreatedLabel.Size = new System.Drawing.Size(52, 16);
            this.NoteFormCreatedLabel.TabIndex = 3;
            this.NoteFormCreatedLabel.Text = "Created:";
            // 
            // NoteFormModifiedLabel
            // 
            this.NoteFormModifiedLabel.AutoSize = true;
            this.NoteFormModifiedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteFormModifiedLabel.Location = new System.Drawing.Point(175, 65);
            this.NoteFormModifiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteFormModifiedLabel.Name = "NoteFormModifiedLabel";
            this.NoteFormModifiedLabel.Size = new System.Drawing.Size(59, 16);
            this.NoteFormModifiedLabel.TabIndex = 4;
            this.NoteFormModifiedLabel.Text = "Modified:";
            // 
            // NoteFormModifiedDateTimePicker
            // 
            this.NoteFormModifiedDateTimePicker.Location = new System.Drawing.Point(237, 63);
            this.NoteFormModifiedDateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NoteFormModifiedDateTimePicker.Name = "NoteFormModifiedDateTimePicker";
            this.NoteFormModifiedDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.NoteFormModifiedDateTimePicker.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(63, 6);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(783, 20);
            this.TitleTextBox.TabIndex = 6;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // NoteFormTextBox
            // 
            this.NoteFormTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteFormTextBox.Location = new System.Drawing.Point(11, 88);
            this.NoteFormTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NoteFormTextBox.Multiline = true;
            this.NoteFormTextBox.Name = "NoteFormTextBox";
            this.NoteFormTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteFormTextBox.Size = new System.Drawing.Size(835, 333);
            this.NoteFormTextBox.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(678, 427);
            this.OkButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(83, 23);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(763, 427);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteFormComboBox
            // 
            this.NoteFormComboBox.FormattingEnabled = true;
            this.NoteFormComboBox.Location = new System.Drawing.Point(63, 35);
            this.NoteFormComboBox.Name = "NoteFormComboBox";
            this.NoteFormComboBox.Size = new System.Drawing.Size(259, 21);
            this.NoteFormComboBox.TabIndex = 12;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.NoteFormComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteFormTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.NoteFormModifiedDateTimePicker);
            this.Controls.Add(this.NoteFormModifiedLabel);
            this.Controls.Add(this.NoteFormCreatedLabel);
            this.Controls.Add(this.NoteFormCreatedDateTimePicker);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MinimumSize = new System.Drawing.Size(577, 313);
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.DateTimePicker NoteFormCreatedDateTimePicker;
        private System.Windows.Forms.Label NoteFormCreatedLabel;
        private System.Windows.Forms.Label NoteFormModifiedLabel;
        private System.Windows.Forms.DateTimePicker NoteFormModifiedDateTimePicker;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox NoteFormTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox NoteFormComboBox;
    }
}
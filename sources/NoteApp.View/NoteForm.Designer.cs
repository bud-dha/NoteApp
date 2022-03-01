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
            this.NoteFormDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.NoteFormTextBox = new System.Windows.Forms.TextBox();
            this.NoteFormScrollBar = new System.Windows.Forms.VScrollBar();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(46, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(12, 52);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(86, 23);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // NoteFormCreatedDateTimePicker
            // 
            this.NoteFormCreatedDateTimePicker.Location = new System.Drawing.Point(104, 87);
            this.NoteFormCreatedDateTimePicker.Name = "NoteFormCreatedDateTimePicker";
            this.NoteFormCreatedDateTimePicker.Size = new System.Drawing.Size(125, 26);
            this.NoteFormCreatedDateTimePicker.TabIndex = 2;
            // 
            // NoteFormCreatedLabel
            // 
            this.NoteFormCreatedLabel.AutoSize = true;
            this.NoteFormCreatedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteFormCreatedLabel.Location = new System.Drawing.Point(12, 90);
            this.NoteFormCreatedLabel.Name = "NoteFormCreatedLabel";
            this.NoteFormCreatedLabel.Size = new System.Drawing.Size(75, 23);
            this.NoteFormCreatedLabel.TabIndex = 3;
            this.NoteFormCreatedLabel.Text = "Created:";
            // 
            // NoteFormModifiedLabel
            // 
            this.NoteFormModifiedLabel.AutoSize = true;
            this.NoteFormModifiedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteFormModifiedLabel.Location = new System.Drawing.Point(244, 90);
            this.NoteFormModifiedLabel.Name = "NoteFormModifiedLabel";
            this.NoteFormModifiedLabel.Size = new System.Drawing.Size(86, 23);
            this.NoteFormModifiedLabel.TabIndex = 4;
            this.NoteFormModifiedLabel.Text = "Modified:";
            // 
            // NoteFormModifiedDateTimePicker
            // 
            this.NoteFormModifiedDateTimePicker.Location = new System.Drawing.Point(336, 87);
            this.NoteFormModifiedDateTimePicker.Name = "NoteFormModifiedDateTimePicker";
            this.NoteFormModifiedDateTimePicker.Size = new System.Drawing.Size(126, 26);
            this.NoteFormModifiedDateTimePicker.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(104, 16);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(775, 26);
            this.TitleTextBox.TabIndex = 6;
            // 
            // NoteFormDomainUpDown
            // 
            this.NoteFormDomainUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteFormDomainUpDown.Location = new System.Drawing.Point(104, 52);
            this.NoteFormDomainUpDown.Name = "NoteFormDomainUpDown";
            this.NoteFormDomainUpDown.Size = new System.Drawing.Size(194, 26);
            this.NoteFormDomainUpDown.TabIndex = 7;
            // 
            // NoteFormTextBox
            // 
            this.NoteFormTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteFormTextBox.Location = new System.Drawing.Point(16, 119);
            this.NoteFormTextBox.Multiline = true;
            this.NoteFormTextBox.Name = "NoteFormTextBox";
            this.NoteFormTextBox.Size = new System.Drawing.Size(863, 417);
            this.NoteFormTextBox.TabIndex = 8;
            // 
            // NoteFormScrollBar
            // 
            this.NoteFormScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteFormScrollBar.Location = new System.Drawing.Point(879, 119);
            this.NoteFormScrollBar.Name = "NoteFormScrollBar";
            this.NoteFormScrollBar.Size = new System.Drawing.Size(25, 420);
            this.NoteFormScrollBar.TabIndex = 9;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(648, 547);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(125, 35);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(779, 547);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(125, 35);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 594);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteFormScrollBar);
            this.Controls.Add(this.NoteFormTextBox);
            this.Controls.Add(this.NoteFormDomainUpDown);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.NoteFormModifiedDateTimePicker);
            this.Controls.Add(this.NoteFormModifiedLabel);
            this.Controls.Add(this.NoteFormCreatedLabel);
            this.Controls.Add(this.NoteFormCreatedDateTimePicker);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "NoteForm";
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
        private System.Windows.Forms.DomainUpDown NoteFormDomainUpDown;
        private System.Windows.Forms.TextBox NoteFormTextBox;
        private System.Windows.Forms.VScrollBar NoteFormScrollBar;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
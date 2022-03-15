using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            var noteForm = new NoteForm();
            var result = noteForm.ShowDialog();

            Note note1 = new Note();
            HeadingLabel.Text = note1.Title;
            MainFormTextBox.Text = note1.Text;
            MainFormCurentCategoryLable.Text = note1.Category.ToString();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Заметка сохранена");
            }
            else
            {
                MessageBox.Show("Заметка не будет сохранена!");
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNoteButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}

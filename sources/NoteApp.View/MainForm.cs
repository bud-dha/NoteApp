using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var noteForm = new NoteForm();
            var result = noteForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Заметка сохранена");
            }
            else {
                MessageBox.Show("Заметка не будет сохранена!");
            }
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            Form noteForm = new NoteForm();
            noteForm.ShowDialog();
        }
    }
}

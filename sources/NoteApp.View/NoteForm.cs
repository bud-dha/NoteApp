﻿using System;
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
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            Form mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

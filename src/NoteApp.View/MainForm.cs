﻿using System;
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
        /// <summary>
        /// Объект класса Project.
        /// </summary>
        private Project _project;

        public MainForm()
        {
            InitializeComponent();

            _project = new Project();
            _project.Notes = new List<Note>();

        }

        /// <summary>
        /// Очищает и добовляет заметки в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            MainFormListBox.Items.Clear();

            for (int i = 0; i < _project.Notes.Count; i++)
            {
                MainFormListBox.Items.Insert(i, _project.Notes.ToArray()[i].Title);
            }
        }

        /// <summary>
        /// Генерирует данные для заполнения Note/NoteForm.
        /// </summary>
        private void AddNote()
        {
            Note note = new Note("1st", "text", NoteCategory.Finance);
            _project.Notes.Add(note);
        }

        /// <summary>
        /// Удаляет выбранную заметку из списка.
        /// </summary>
        /// <param name="index">Индекс удаляемого из списка элемента</param>
        private void RemoveNote(int index)
        {
            _project.Notes.RemoveAt(index);
            MainFormListBox.SetSelected(index, false);
        }

        /// <summary>
        /// Заполняет данные на правой панели главного окна.
        /// </summary>
        private void UpdateSelectedNote(int index)
        {
            if (MainFormListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                HeadingLabel.Text = _project.Notes.ToArray()[index].Title;
                MainFormCurentCategoryLable.Text = _project.Notes.ToArray()[index].Category.ToString();
                MainFormTextBox.Text = _project.Notes.ToArray()[index].Text;
                MainFormCreatedDateTimePicker.Text = _project.Notes.ToArray()[index].CreatedDateTime.ToString();
                MainFormModifiedDateTimePicker.Text = _project.Notes.ToArray()[index].ModifiedDateTime.ToString();
            }
        }

        /// <summary>
        /// Очищает данные с правой панели главного окна.
        /// </summary>
        private void ClearSelectedNote()
        {
            HeadingLabel.Text = "";
            MainFormCurentCategoryLable.Text = NoteCategory.Other.ToString();
            MainFormTextBox.Text = "";
            MainFormCreatedDateTimePicker.Text = DateTime.Now.ToString();
            MainFormModifiedDateTimePicker.Text = DateTime.Now.ToString();
        }


        /// <summary>
        /// Создает новую заметку.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();

            var noteForm = new NoteForm();
            var result = noteForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Note saved");
            }
            else
            {
                MessageBox.Show("Note not be saved!");
            }
        }

        /// <summary>
        /// Создает новую заметку.
        /// </summary>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNoteButton_Click(sender, e);
        }

        /// <summary>
        /// Удаляет заметку.
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            if (MainFormListBox.SelectedIndex == -1)
            {
                return;
            }

            var result = MessageBox.Show("Do you realy want to remove " + 
                _project.Notes.ToArray()[MainFormListBox.SelectedIndex].Title + "?", "", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                RemoveNote(MainFormListBox.SelectedIndex);
            }
            else if(result == DialogResult.No)
            {
                return;
            }

            UpdateListBox();
        }

        /// <summary>
        /// Удаляет заметку.
        /// </summary>
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNoteButton_Click(sender, e);
        }

        /// <summary>
        /// Обрабатывает клик по заметки.
        /// </summary>
        private void MainFormListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedNote(MainFormListBox.SelectedIndex);
        }

        /// <summary>
        /// Вызывает AboutForm.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Завершает работу приложения.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обрабатывает событие закрытия программы.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result =  MessageBox.Show("Do you really want to close the program?", "" , MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else {
                e.Cancel = false;
            }
        }
    }
}

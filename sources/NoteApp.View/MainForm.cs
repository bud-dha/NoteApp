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
        /// <summary>
        /// Объект класса Project.
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Project = new Project();
            Project.Notes = new List<Note>();

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                MainFormComboBox.Items.Add(category);
            }

            MainFormComboBox.Items.Add("All");
            MainFormComboBox.SelectedItem = "All";
        }

        /// <summary>
        /// Очищает и добавляет заметки в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            MainFormListBox.Items.Clear();

            for (int i = 0; i < Project.Notes.Count; i++)
            {
                MainFormListBox.Items.Insert(i, Project.Notes.ToArray()[i].Title);
            }
        }

        /// <summary>
        /// Удаляет выбранную заметку из списка.
        /// </summary>
        /// <param name="index">Индекс удаляемого из списка элемента</param>
        private void RemoveNote(int index)
        {
            Project.Notes.RemoveAt(index);
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
                HeadingLabel.Text = Project.Notes.ToArray()[index].Title;
                MainFormCurentCategoryLable.Text = Project.Notes.ToArray()[index].Category.ToString();
                MainFormTextBox.Text = Project.Notes.ToArray()[index].Text;
                MainFormCreatedDateTimePicker.Text = Project.Notes.ToArray()[index].CreatedDateTime.ToString();
                MainFormModifiedDateTimePicker.Text = Project.Notes.ToArray()[index].ModifiedDateTime.ToString();
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
        /// Вызыывает метод создания заметки.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Вызыывает метод создания заметки.
        /// </summary>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Вызывает метод редактирования заметки.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Вызывает метод редактирования заметки.
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Вызыывает метод удаления заметки.
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Вызыывает метод удаления заметки.
        /// </summary>
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
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
            var result =  MessageBox.Show("Вы действительно хотите закрыть программу?", "" , MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else 
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Создает заметку.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            var result = noteForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Project.Notes.Add(noteForm.Note);
            }
            UpdateListBox();
        }

        /// <summary>
        /// Редактирует заметку.
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = MainFormListBox.SelectedIndex;
            var selectedNote = Project.Notes[selectedIndex];            
            var noteForm = new NoteForm();
            noteForm.Note = selectedNote;
            var result = noteForm.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                var updatedData = noteForm.Note;

                MainFormListBox.Items.RemoveAt(selectedIndex);
                Project.Notes.RemoveAt(selectedIndex);
                Project.Notes.Insert(selectedIndex, updatedData);
                UpdateListBox();
            }            
        }

        /// <summary>
        /// Удаляет заметку.
        /// </summary>
        private void RemoveNote()
        {
            if (MainFormListBox.SelectedIndex == -1)
            {
                return;
            }
            var result = MessageBox.Show("Вы действительно хотите удалить '" +
                Project.Notes.ToArray()[MainFormListBox.SelectedIndex].Title + "'?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                RemoveNote(MainFormListBox.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            UpdateListBox();
        }
    }
}

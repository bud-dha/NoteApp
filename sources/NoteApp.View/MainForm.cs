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
        private Project _project;

        public MainForm()
        {
            InitializeComponent();

            _project = new Project();
            _project.Notes = new List<Note>();
            _project.NotesByCat = new List<Note>();

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                MainFormComboBox.Items.Add(category);
            }

            MainFormComboBox.Items.Add("All");
            MainFormComboBox.SelectedItem = "All";

            UpdateListBox();
        }

        /// <summary>
        /// Очищает и добавляет заметки в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            if (_project.Notes.Count == 0)
            {
                ClearSelectedNote();
                MainFormListBox.Items.Clear();                
                return;
            }

            MainFormListBox.Items.Clear();

            _project.Notes = _project.NotesByDate();
            _project.Notes.Reverse();
            _project.NotesByCat = CheckCategory(_project.Notes);            

            for (int i = 0; i < _project.NotesByCat.Count; i++)
            {
                MainFormListBox.Items.Insert(i, _project.NotesByCat.ToArray()[i].Title);
            }
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
                HeadingLabel.Text = _project.NotesByCat.ToArray()[index].Title;
                MainFormCurentCategoryLable.Text = _project.NotesByCat.ToArray()[index].Category.ToString();
                MainFormTextBox.Text = _project.NotesByCat.ToArray()[index].Text;
                MainFormCreatedDateTimePicker.Text = _project.NotesByCat.ToArray()[index].CreatedDateTime.ToString();
                MainFormModifiedDateTimePicker.Text = _project.NotesByCat.ToArray()[index].ModifiedDateTime.ToString();
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
            var noteForm = new NoteForm(null);
            var result = noteForm.ShowDialog();
            if (result == DialogResult.OK && noteForm.Note != null)
            {
                _project.Notes.Add(noteForm.Note);
            }

            DialogResultMessage(result);
            UpdateListBox();
        }
        /// <summary>
        /// Создает новую заметку.
        /// </summary>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNoteButton_Click(sender, e);
        }
        /// <summary>
        /// Редактирует заметку.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = MainFormListBox.SelectedIndex;
            var selectedItem = _project.Notes[selectedIndex];
            var noteForm = new NoteForm(selectedItem);
            var result = noteForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var updatedData = noteForm.Note;

                MainFormListBox.Items.RemoveAt(selectedIndex);
                _project.Notes.RemoveAt(selectedIndex);
                _project.Notes.Insert(selectedIndex, updatedData);
            }
            DialogResultMessage(result);
            UpdateListBox();
        }
        /// <summary>
        /// Редактирует заметку.
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNoteButton_Click(sender, e);
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
        /// <summary>
        /// Возвращает список заметок по категории.
        /// </summary>
        private void MainFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        /// <summary>
        /// Возвращает текстовое сообщение.
        /// </summary>
        private void DialogResultMessage(DialogResult result)
        {
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
        /// Возвращает список заметок по выбранной категории.
        /// </summary>
        private List<Note> CheckCategory(List<Note> Notes)
        {
            switch (MainFormComboBox.SelectedIndex)
            {
                case 0:
                   Notes = _project.NotesByCategory(NoteCategory.Work);
                   return Notes;
                case 1:
                    Notes = _project.NotesByCategory(NoteCategory.Home);
                    return Notes;
                case 2:
                    Notes = _project.NotesByCategory(NoteCategory.HealthAndSports);
                    return Notes;
                case 3:
                    Notes = _project.NotesByCategory(NoteCategory.People);
                    return Notes;
                case 4:
                    Notes = _project.NotesByCategory(NoteCategory.Documents);
                    return Notes;
                case 5:
                    Notes = _project.NotesByCategory(NoteCategory.Finance);
                    return Notes;
                case 6:
                    Notes = _project.NotesByCategory(NoteCategory.Other);
                    return Notes;
                case 7:
                    return Notes;
            }
            return Notes;
        }

    }
}

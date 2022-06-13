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
        /// Возвращает и задает текущий список заметок пользователя.
        /// </summary>
        private List<Note> CurentNotes { get; set; }

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
            CurentNotes = new List<Note>();

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
            MainFormListBox.Items.Clear();
            Project.Notes = Project.NotesByDate();
            Project.Notes.Reverse();
            CurentNotes = CheckCategory(Project.Notes);            

            for (int i = 0; i < CurentNotes.Count; i++)
            {
                MainFormListBox.Items.Insert(i, CurentNotes.ToArray()[i].Title);
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
            int curentIndex = 0;

            if (MainFormListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                for (int i= 0; i < CurentNotes.Count; i++ )
                {
                    if (CurentNotes.ToArray()[index].Text == Project.Notes.ToArray()[i].Text)
                    {
                        curentIndex = i;
                    }
                }
                HeadingLabel.Text = CurentNotes.ToArray()[curentIndex].Title;
                MainFormCurentCategoryLable.Text = CurentNotes.ToArray()[curentIndex].Category.ToString();
                MainFormTextBox.Text = CurentNotes.ToArray()[curentIndex].Text;
                MainFormCreatedDateTimePicker.Text = CurentNotes.ToArray()[curentIndex].CreatedDateTime.ToString();
                MainFormModifiedDateTimePicker.Text = CurentNotes.ToArray()[curentIndex].ModifiedDateTime.ToString();
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
        /// Вызывает метод создания новой заметки.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Вызывает метод создания новой заметки.
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
        /// Вызывает метод удаления заметки.
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Вызывает метод удаления заметки.
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
        /// Создает новую заметку.
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

        /// <summary>
        /// Возвращает список заметок по выбранной категории.
        /// </summary>
        private List<Note> CheckCategory(List<Note> Notes)
        {
            switch (MainFormComboBox.SelectedIndex)
            {
                case 0:
                   Notes = Project.NotesByCategory(NoteCategory.Work);
                   return Notes;
                case 1:
                    Notes = Project.NotesByCategory(NoteCategory.Home);
                    return Notes;
                case 2:
                    Notes = Project.NotesByCategory(NoteCategory.HealthAndSports);
                    return Notes;
                case 3:
                    Notes = Project.NotesByCategory(NoteCategory.People);
                    return Notes;
                case 4:
                    Notes = Project.NotesByCategory(NoteCategory.Documents);
                    return Notes;
                case 5:
                    Notes = Project.NotesByCategory(NoteCategory.Finance);
                    return Notes;
                case 6:
                    Notes = Project.NotesByCategory(NoteCategory.Other);
                    return Notes;
                case 7:
                    return Notes;
            }
            return Notes;
        }

    }
}

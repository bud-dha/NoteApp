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
        private Project Project;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            Project = ProjectSerializer.LoadFromFile();
            InitializeComponent();

            Project = new Project();
            Project.Notes = new List<Note>();
            Project.NotesByCat = new List<Note>();

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
            Project.Notes = CheckCategory(Project.Notes);

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
        /// Создает новую заметку.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {            
            AddNote();
        }

        /// <summary>
        /// Создает новую заметку.
        /// </summary>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактирует заметку.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Редактирует заметку.
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Удаляет заметку.
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }
        /// <summary>
        /// Удаляет заметку.
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
            ProjectSerializer.SaveToFile(Project);
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
                ProjectSerializer.SaveToFile(Project);
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
                MessageBox.Show("Заметка сохранена");
            }
            else
            {
                MessageBox.Show("Заметка не будет сохранена!");
            }
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
                ProjectSerializer.SaveToFile(Project);
            }
            UpdateListBox();
        }

        /// <summary>
        /// Редактирует заметку.
        /// </summary>
        private void EditNote()
        {
            try
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
                    ProjectSerializer.SaveToFile(Project);
                }
            }
            catch
            {
                MessageBox.Show("Необходимо выбрать заметку!");
            }
            UpdateListBox();
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
                ProjectSerializer.SaveToFile(Project);
            }
            else if (result == DialogResult.No)
            {
                return;
            }

            UpdateListBox();
        }

        /// <summary>
        /// 
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
            }
            return Notes;
        }

    }
}

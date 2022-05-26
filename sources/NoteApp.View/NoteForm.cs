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
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Свойство для передачи новой заметки.
        /// </summary>
        public Note Note { get; set; }
        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string _titleError;
        /// <summary>
        /// Цвет некоректного ввода.
        /// </summary>
        private readonly Color _wrongValueColor = Color.LightPink;
        /// <summary>
        /// Цвет коректного ввода.
        /// </summary>
        private readonly Color _correctValueColor = Color.White;

        public NoteForm(Note note)
        {
            InitializeComponent();

            NoteFormComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));

            if (note == null)
            {
                note = new Note();
            }

            Note = note;

            UpdateForm();
        }

        /// <summary>
        /// Заполняет поля формы данными из полей Note.
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = Note.Title;
            NoteFormComboBox.SelectedItem = Note.Category;
            NoteFormTextBox.Text = Note.Text;
        }
        /// <summary>
        /// Заполняет поля Note данными из полей формы.
        /// </summary>
        private void UpdateNote()
        {
            Note.Title = TitleTextBox.Text;
            Note.Category = (NoteCategory)NoteFormComboBox.SelectedItem;
            Note.Text = NoteFormTextBox.Text;
        }
        /// <summary>
        /// Проверяет форму на наличие ошибок.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if (_titleError.Length > 1)
            {
                MessageBox.Show(_titleError);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Обрабатывет изменения в текстовом поле.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _correctValueColor;
                _titleError = "";
            }
            catch (Exception exception)
            {
                TitleTextBox.BackColor = _wrongValueColor;
                _titleError = exception.Message;
            }
        }
        /// <summary>
        /// Обрабатывает клик по кнопке ОК.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateNote();
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Обрабатывает клик по кнопке Cancel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

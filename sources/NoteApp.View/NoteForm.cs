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
        /// Объект класса Note.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string _titleError;

        public NoteForm()
        {
            InitializeComponent();

            NoteFormComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));

            _note = new Note();
            _note.Title = "HBG";
            _note.Text = "djvndc ndnc dscdjnc";

            UpdateForm();
        }

        /// <summary>
        /// Заполняет поля формы данными из плоля _note.
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _note.Title;
            NoteFormComboBox.Text = _note.Category.ToString();
            NoteFormTextBox.Text = _note.Text;
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
        /// Обновляет данные в объекте _note.
        /// </summary>
        private void UpdateNote()
        {
            _note.Title = TitleTextBox.Text;
            //_note.Category = NoteFormComboBox;
            _note.Text = NoteFormTextBox.Text;
        }


        /// <summary>
        /// Обрабатывет изменения в текстовом поле.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;

                _titleError = "";
            }
            catch (Exception exception)
            {
                TitleTextBox.BackColor = Color.LightPink;

                _titleError = exception.Message;
            }
        }

        /// <summary>
        /// Обрабатывает клик по кнопке ОК.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CheckFormOnErrors();
            UpdateNote();
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

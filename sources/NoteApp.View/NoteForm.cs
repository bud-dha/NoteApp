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
        /// Поле для хранения обьектов Note
        /// </summary>
        private Note _note;

        /// <summary>
        /// Поле для хранения сообщения об ошибке
        /// </summary>
        private string _titleError;

        public NoteForm()
        {
            InitializeComponent();

            _note = new Note();
            _note.Title = "HBG";
            _note.Text = "djvndc ndnc dscdjnc";

            UpdateForm();
        }

        /// <summary>
        /// Метод заполняющий поля формы данными из обекта
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _note.Title;
            NoteFormComboBox.Text = _note.Category.ToString();
            NoteFormTextBox.Text = _note.Text;
        }

        /// <summary>
        /// Валидация данных названия заметки
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;
                _titleError = "";
            }
            catch(Exception exception)
            {
                TitleTextBox.BackColor = Color.LightPink;
                _titleError = exception.Message;
            }
        }

        /// <summary>
        /// Метод проверяющий форму на наличие ошибок
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_titleError != null)
            {
                MessageBox.Show(_titleError);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Метод 
        /// </summary>
        private void UpdateNote()
        {
            _note.Title = TitleTextBox.Text;
            // _note.Category = NoteFormComboBox.SelectedIndex.ToString();
            _note.Text = NoteFormTextBox.Text;
        }


        /// <summary>
        /// Обработчик клика по кнопке ОК
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CheckFormOnErrors();
            UpdateNote();
        }

        /// <summary>
        /// Обработчик клика по кнопке Cancel
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

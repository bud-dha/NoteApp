using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model 
{
    /// <summary>
    /// Класс заметок
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название по умолчанию
        /// </summary>
        private string _title = "Без названия";

        /// <summary>
        /// Текст по умолчанию
        /// </summary>
        private string _text = " ";

        /// <summary>
        /// Категория по умолчанию
        /// </summary>
        private NoteCategory _category = NoteCategory.Other;

        /// <summary>
        /// Время создания
        /// </summary>
        private DateTime CreateDateTime = DateTime.Now;

        /// <summary>
        /// Время изменения 
        /// </summary>
        private DateTime ModifiedDateTime;

        /// <summary>
        /// Геттер, сеттер для названия заметки
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Название ограничено 50 символами!");
                }
                if (value == string.Empty)
                {
                    _title = "Без названия";
                }
                _title = value;
                ModifiedDateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Геттер и сеттер для текста заметки
        /// </summary>
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                ModifiedDateTime = DateTime.Now;
            }
        }

      /// <summary>
      /// Геттер и сеттер для категории
      /// </summary>
        public NoteCategory Category
        {
            get => _category;
            set
            {
                _category = value;
                ModifiedDateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="text">Текст</param>
        /// <param name="category">Категория</param>
        public Note(string title, string text, NoteCategory category)
        {
            _title = title;
            _text = text;
            _category = category;
        }

        /// <summary>
        /// Кончтруктор по умолчанию
        /// </summary>
        public Note() { }
        
        /// <summary>
        /// ICloneable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var note = new Note();
            note.Title = this.Title;
            note.Text = this.Text;
            note.Category = this.Category;
            note.CreateDateTime = this.CreateDateTime;
            note.ModifiedDateTime = this.ModifiedDateTime;
            
            return note;
        }

    }
}

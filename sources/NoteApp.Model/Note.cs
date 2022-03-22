using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model 
{
    /// <summary>
    /// Класс заметок.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title = "Без названия";

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text = " ";

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category = NoteCategory.Other;

        /// <summary>
        /// Время создания.
        /// </summary>
        private DateTime CreateDateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Время изменения. 
        /// </summary>
        private DateTime ModifiedDateTime { get; set; }


        /// <summary>
        /// Геттер, сеттер для названия заметки.
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
        /// Геттер и сеттер для текста заметки.
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
      /// Геттер и сеттер для категории.
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
        /// Конструктор.
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="text">Текст</param>
        /// <param name="category">Категория</param>
        public Note(string title, string text, NoteCategory category)
        {
            Title = title;
            Text = text;
            Category = category;
        }


        /// <summary>
        /// Конcтруктор по умолчанию.
        /// </summary>
        public Note() { }
        
        /// <summary>
        /// ICloneable.
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

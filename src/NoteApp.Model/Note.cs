using System;

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
        private string _text = "";

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category = NoteCategory.Other;

        /// <summary>
        /// Возвращает время создания заметки.
        /// </summary>
        public DateTime CreatedDateTime { get; private set; } = DateTime.Now;

        /// <summary>
        /// Возвращает время изменения заметки. 
        /// </summary>
        public DateTime ModifiedDateTime { get; private set; }


        /// <summary>
        /// Возвращает и задает категорию заметки.
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
        /// Возвращает и задает текст заметки.
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
        /// Возвращает и задает категорию заметки.
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
        /// Создает экземпляр класса <see cref="Note">
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
        /// Создает экземпляр кдасса <see cref="Note">
        /// </summary>
        public Note() { }

        /// <summary>
        /// Создает копию класса <see cref="Note">
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var note = new Note();
            note.Title = this.Title;
            note.Text = this.Text;
            note.Category = this.Category;
            note.CreatedDateTime = this.CreatedDateTime;
            note.ModifiedDateTime = this.ModifiedDateTime;

            return note;
        }

    }
}
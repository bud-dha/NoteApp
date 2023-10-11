using System.Collections.Generic;

namespace NoteApp.Model
{
    /// <summary>
    /// Хранит все пользовательские данные текущей сессии.
    /// </summary>
    public class Project
    {
        /// <list>
        /// Возвращает и задает список заметок пользователя.
        /// </list>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
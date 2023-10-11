using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

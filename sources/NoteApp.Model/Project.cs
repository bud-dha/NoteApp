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
        /// <summary>
        /// Текущая заметка.
        /// </summary>
        public Note CurrentNote { get; set; }
        /// <summary>
        /// Возвращает список заметок отсортированных по дате редактирования.
        /// </summary>
        public List<Note> NotesByDate()
        {
            if (Notes.Count != 0)
            {
                return Notes.OrderBy(t => t.ModifiedDateTime).ToList();
            }
            return Notes;
        }
        /// <summary>
        /// Возвращает список заметок отсортированных по катрегории.
        /// </summary>
        public List<Note> NotesByCategory(NoteCategory category)
        {
            if (Notes.Count != 0)
            {
              return Notes.Where(t => t.Category == category).ToList();
            }
            return Notes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    public class Project
    {
        /// <list>
        /// Возвращает и задает список заметок пользователя.
        /// </list>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}

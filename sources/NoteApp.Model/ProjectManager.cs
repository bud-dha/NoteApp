using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp.Model
{
    /// <summary>
    /// Созраняет и выгружает пользовательские данные.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Название файла сохранения.
        /// </summary>
        public static string FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "NoteApp";

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>        
        public static void SaveToFile(Project project)
        {
            var serializer = new JsonSerializer();            
            using (var sw = new StreamWriter(FileName)) 
            using (JsonWriter writer = new JsonTextWriter(sw)) 
            {                 
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Возвращает данные из файла.
        /// </summary>        
        public static Project LoadFromFile()
        {
            var serializer = new JsonSerializer();
            try
            {
                using (var sr = new StreamReader(FileName))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var project = (Project)serializer.Deserialize<Project>(reader);
                    if (project == null)
                    {
                        return new Project();
                    }

                    return project;
                }
            }
            catch (Exception exception)
            {
                return new Project();
            }
        }
    }
}

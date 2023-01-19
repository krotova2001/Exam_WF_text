using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_WF
{
    //класс элемента избранного
    internal class Favorite
    {
        public string Content { get; set; } // содержание
        public DateTime time { get; } // время добавления
        public string Path { get; set; } // путь файла, с которого взяли закладку
        public override string ToString() // отображение начала содержания
        {
            if (Content.Length > 8)
                return Content.Substring(0, 8) + "...";
            return Content;
        }
        public Favorite() {} // для сериализации
        public Favorite(string path) //для создания нового экземпляра, вместо десериализации
        {
            Path = path;
            time = DateTime.Now;
        }
    }
}

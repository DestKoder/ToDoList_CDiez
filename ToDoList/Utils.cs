using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Utils
    {
        public static string TimeFormat = "HH:mm dd/MM/yyyy";
        public static string getToDoPriorityAlias(ToDoPriority priority)
        {
            switch (priority)
            {
                case ToDoPriority.HIGHEST:
                    return "Высокий";
                case ToDoPriority.MEDIUM:
                    return "Обычный";
                case ToDoPriority.LOWEST:
                    return "Назкий";
                default:
                    return "Ошибка";
            }
        }
    }
}

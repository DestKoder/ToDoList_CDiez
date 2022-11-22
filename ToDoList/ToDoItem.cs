using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public enum ToDoPriority
    {
        HIGHEST,
        MEDIUM,
        LOWEST
    }

    public class ToDoItem : IComparable
    {
        public ToDoPriority Priority { get; set; }

        public String ShortName { get; set; }
        public String ToDo { get; set; }
        public DateTime ToDoDate { get; set; }

        public ToDoItem(ToDoPriority priority, string toDo, DateTime toDoDate, string shortName)
        {
            Priority = priority;
            ToDo = toDo;
            ToDoDate = toDoDate;
            ShortName = shortName;
        }
        
        public ToDoItem() { }

        public override string ToString()
        {
            //return $"{ShortName}. Выполнить до {ToDoDate.ToString(Utils.TimeFormat)}";
            return $"{ShortName}. Приоритет: {Utils.getToDoPriorityAlias(Priority)}";
        }

        public int CompareTo(object obj)
        {
            ToDoItem item = obj as ToDoItem;

            if (item != null)
            {
                if (((int)Priority) > ((int)item.Priority)) return 1;
                else if (Priority == item.Priority) return 0;
                else return -1;
            }
            else throw new ArgumentException("object is not a ToDoItem");
        }
    }
}

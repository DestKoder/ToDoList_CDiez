using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public class ToDoData
    {
        public List<ToDoItem> toDoList { get; set; } = new List<ToDoItem>();
        

        public void setToDos(ListBox listbox)
        {
            listbox.Items.Clear();
            
            toDoList.Sort();

            int counter = 0;

            foreach(ToDoItem item  in toDoList)
            {
                listbox.Items.Add($"{counter}. {item.ToString()}");
                counter++;
            }
        }

        public ToDoItem getById(int id)
        {
            return toDoList[id];
        }

        public void remove(int id)
        {
            toDoList.RemoveAt(id);
        }

        internal void addToDo(ToDoItem result)
        {
            toDoList.Add(result);
        }

        //TODO: Add search methods
    }
}

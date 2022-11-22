using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.form
{
    public partial class ToDoListForm : Form
    {
        private String dataFile;
        private ToDoData data;

        private AddToDo addForm;
        public ToDoListForm(User user)
        {
            InitializeComponent();
            this.dataFile = user.Login.ToLower() + "_todos";
            login.Text = user.Login;

            dateTimePicker1.CustomFormat = Utils.TimeFormat;
        }


        //Remove ToDo;
        private void button3_Click(object sender, EventArgs e)
        {
            data.remove(toDoList.SelectedIndex);

            data.setToDos(toDoList);
        }

        //Create ToDo
        private void button1_Click(object sender, EventArgs e)
        {
            this.addForm = new AddToDo();

            if(addForm.ShowDialog() == DialogResult.OK)
            {
                this.data.addToDo(addForm.result);

                data.setToDos(toDoList);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDoItem item = data.getById(toDoList.SelectedIndex);
            toDo.Text = item.ToDo;

            dateTimePicker1.Value = item.ToDoDate; 
        }

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            data = (ToDoData)Serializator.Deserialize(typeof(ToDoData), dataFile);

            if (data == null) data = new ToDoData();

            data.setToDos(toDoList);
            
            if(data.toDoList.Count > 0)
            {
                toDoList.SelectedIndex = 0;
            }
        }

        private void ToDoListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializator.Serialize(typeof(ToDoData), data, dataFile);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Save toDo info;
        private void button2_Click(object sender, EventArgs e)
        {
            ToDoItem item = data.getById(toDoList.SelectedIndex);

            item.ToDoDate = dateTimePicker1.Value;
            item.ToDo = toDo.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}

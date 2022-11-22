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
    public partial class AddToDo : Form
    {
        public ToDoItem result;

        public AddToDo()
        {
            InitializeComponent();
            time.Value = DateTime.Now;
            time.CustomFormat = Utils.TimeFormat;
            priority.SelectedIndex = 0;
        }

        private void AddToDo_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shortName.Text) || string.IsNullOrWhiteSpace(ToDo.Text)) return;

            this.result = new ToDoItem((ToDoPriority)priority.SelectedIndex, ToDo.Text, time.Value, shortName.Text);
            DialogResult = DialogResult.OK;
        }
    }
}

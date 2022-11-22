using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.form;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private Users users;
        private Registration registration;

        public Form1()
        {
            InitializeComponent();
            users = new Users();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Users tmp = (Users)Serializator.Deserialize(typeof(Users), "users");

            if (tmp != null) users = tmp;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializator.Serialize(typeof(Users), users, "users");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text)) return;

            User user = users.tryAuth(login.Text, password.Text);

            if(user == null)
            {
                MessageBox.Show("Invalid credentials");
                return;
            }

            this.Visible = false;
            DialogResult result = new ToDoListForm(user).ShowDialog();
            
            this.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;

            registration = new Registration();

            DialogResult result = registration.ShowDialog();

            if(result == DialogResult.OK)
            {
                this.Visible = true;
                this.users.addUser(registration.user);
            }
        }
    }
}

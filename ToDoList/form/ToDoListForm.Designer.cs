namespace ToDoList.form
{
    partial class ToDoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toDoList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.Location = new System.Drawing.Point(13, 52);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(269, 381);
            this.toDoList.TabIndex = 0;
            this.toDoList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать дело";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить дело";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список дел пользователя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(449, 9);
            this.login.Name = "login";
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.login.Size = new System.Drawing.Size(41, 17);
            this.login.TabIndex = 5;
            this.login.Text = "еуые";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(288, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Необходимо сделать:";
            // 
            // toDo
            // 
            this.toDo.Location = new System.Drawing.Point(291, 85);
            this.toDo.Multiline = true;
            this.toDo.Name = "toDo";
            this.toDo.Size = new System.Drawing.Size(269, 174);
            this.toDo.TabIndex = 7;
            this.toDo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(288, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выполнить до";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toDoList);
            this.Name = "ToDoListForm";
            this.Text = "ToDoListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToDoListForm_FormClosing);
            this.Load += new System.EventHandler(this.ToDoListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox toDoList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toDo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
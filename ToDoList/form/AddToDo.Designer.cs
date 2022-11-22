namespace ToDoList.form
{
    partial class AddToDo
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
            this.ToDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shortName = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToDo
            // 
            this.ToDo.Location = new System.Drawing.Point(12, 82);
            this.ToDo.Multiline = true;
            this.ToDo.Name = "ToDo";
            this.ToDo.Size = new System.Drawing.Size(328, 219);
            this.ToDo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Что необходимо сделать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Краткое название";
            // 
            // shortName
            // 
            this.shortName.Location = new System.Drawing.Point(115, 31);
            this.shortName.Name = "shortName";
            this.shortName.Size = new System.Drawing.Size(219, 20);
            this.shortName.TabIndex = 3;
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(134, 330);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 20);
            this.time.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время выполнения";
            // 
            // priority
            // 
            this.priority.FormattingEnabled = true;
            this.priority.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.priority.Location = new System.Drawing.Point(134, 361);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(200, 21);
            this.priority.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Приоритет";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(77, 396);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(204, 42);
            this.create.TabIndex = 8;
            this.create.Text = "Создать дело";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // AddToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.shortName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDo);
            this.Name = "AddToDo";
            this.Text = "AddToDo";
            this.Load += new System.EventHandler(this.AddToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortName;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button create;
    }
}
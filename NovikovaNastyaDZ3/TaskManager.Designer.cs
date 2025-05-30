namespace NovikovaNastyaDZ3
{
    partial class TaskManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTasks = new ListBox();
            btnAddTask = new Button();
            btnDeleteTask = new Button();
            btnChangeTask = new Button();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = Color.Azure;
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 32;
            listBoxTasks.Items.AddRange(new object[] { "Задачи" });
            listBoxTasks.Location = new Point(44, 213);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(789, 324);
            listBoxTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.CornflowerBlue;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Location = new Point(725, 72);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(219, 46);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.CornflowerBlue;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.Location = new Point(44, 554);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(223, 46);
            btnDeleteTask.TabIndex = 2;
            btnDeleteTask.Text = "Удалить задачу";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnChangeTask
            // 
            btnChangeTask.BackColor = Color.CornflowerBlue;
            btnChangeTask.FlatStyle = FlatStyle.Flat;
            btnChangeTask.Location = new Point(334, 554);
            btnChangeTask.Name = "btnChangeTask";
            btnChangeTask.Size = new Size(274, 46);
            btnChangeTask.TabIndex = 3;
            btnChangeTask.Text = "Редактировать задачу";
            btnChangeTask.UseVisualStyleBackColor = false;
            btnChangeTask.Click += btnChangeTask_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Location = new Point(44, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Название задачи:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveBorder;
            txtTitle.Location = new Point(284, 32);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(405, 45);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveBorder;
            txtDescription.Location = new Point(284, 115);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(405, 81);
            txtDescription.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(44, 115);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 7;
            label1.Text = "Описание задачи:";
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1009, 624);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(btnChangeTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnAddTask);
            Controls.Add(listBoxTasks);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TaskManager";
            Text = "TaskManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTasks;
        private Button btnAddTask;
        private Button btnDeleteTask;
        private Button btnChangeTask;
        private Label lblTitle;
        public TextBox txtTitle;
        private TextBox txtDescription;
        private Label label1;
    }
}

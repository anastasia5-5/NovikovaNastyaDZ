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
            comboBoxImplementers = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = Color.Azure;
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 32;
            listBoxTasks.Items.AddRange(new object[] { "Задачи" });
            listBoxTasks.Location = new Point(25, 261);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(950, 356);
            listBoxTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.CornflowerBlue;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Location = new Point(1040, 86);
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
            btnDeleteTask.Location = new Point(1018, 299);
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
            btnChangeTask.Location = new Point(1001, 389);
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
            lblTitle.Location = new Point(25, 22);
            lblTitle.MinimumSize = new Size(0, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 45);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Название задачи:";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveBorder;
            txtTitle.Location = new Point(284, 22);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(691, 45);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveBorder;
            txtDescription.Location = new Point(284, 86);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(691, 81);
            txtDescription.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(25, 86);
            label1.MinimumSize = new Size(0, 45);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 7;
            label1.Text = "Описание задачи:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxImplementers
            // 
            comboBoxImplementers.FormattingEnabled = true;
            comboBoxImplementers.Items.AddRange(new object[] { "Федя Петров", "Мария Сидорова", "Катя Иванова" });
            comboBoxImplementers.Location = new Point(284, 183);
            comboBoxImplementers.Name = "comboBoxImplementers";
            comboBoxImplementers.Size = new Size(278, 40);
            comboBoxImplementers.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(25, 183);
            label2.MinimumSize = new Size(0, 45);
            label2.Name = "label2";
            label2.Size = new Size(248, 45);
            label2.TabIndex = 9;
            label2.Text = "Исполнитель задачи:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1287, 624);
            Controls.Add(label2);
            Controls.Add(comboBoxImplementers);
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
        private ComboBox comboBoxImplementers;
        private Label label2;
    }
}

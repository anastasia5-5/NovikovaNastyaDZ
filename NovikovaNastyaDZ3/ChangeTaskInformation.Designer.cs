namespace NovikovaNastyaDZ3
{
    partial class ChangeTaskInformation
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
            lblTitle = new Label();
            lblIsCompleted = new Label();
            checkBoxIsCompleted = new CheckBox();
            txtTitle = new TextBox();
            btnOK = new Button();
            txtDescription = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Location = new Point(51, 52);
            lblTitle.MinimumSize = new Size(0, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название задачи:";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIsCompleted
            // 
            lblIsCompleted.AutoSize = true;
            lblIsCompleted.BackColor = SystemColors.ActiveCaption;
            lblIsCompleted.FlatStyle = FlatStyle.Flat;
            lblIsCompleted.Location = new Point(51, 228);
            lblIsCompleted.MinimumSize = new Size(212, 50);
            lblIsCompleted.Name = "lblIsCompleted";
            lblIsCompleted.Size = new Size(212, 50);
            lblIsCompleted.TabIndex = 1;
            lblIsCompleted.Text = "Сделано";
            lblIsCompleted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxIsCompleted
            // 
            checkBoxIsCompleted.AutoSize = true;
            checkBoxIsCompleted.Location = new Point(318, 229);
            checkBoxIsCompleted.MinimumSize = new Size(50, 50);
            checkBoxIsCompleted.Name = "checkBoxIsCompleted";
            checkBoxIsCompleted.Size = new Size(50, 50);
            checkBoxIsCompleted.TabIndex = 2;
            checkBoxIsCompleted.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveBorder;
            txtTitle.Location = new Point(318, 52);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(404, 50);
            txtTitle.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.CornflowerBlue;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(562, 346);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 46);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveBorder;
            txtDescription.Location = new Point(318, 130);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(404, 78);
            txtDescription.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(51, 130);
            label1.MinimumSize = new Size(0, 50);
            label1.Name = "label1";
            label1.Size = new Size(212, 50);
            label1.TabIndex = 6;
            label1.Text = "Описание задачи:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangeTaskInformation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(btnOK);
            Controls.Add(txtTitle);
            Controls.Add(checkBoxIsCompleted);
            Controls.Add(lblIsCompleted);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChangeTaskInformation";
            Text = "ChangeTaskInformation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblIsCompleted;
        public CheckBox checkBoxIsCompleted;
        public TextBox txtTitle;
        public Button btnOK;
        private Label label1;
        public TextBox txtDescription;
    }
}
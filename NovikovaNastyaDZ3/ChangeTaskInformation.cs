namespace NovikovaNastyaDZ3
{
    public partial class ChangeTaskInformation : Form
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }

        public ChangeTaskInformation(TaskItem task)
        {
            InitializeComponent();
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            checkBoxIsCompleted.Checked = task.IsCompleted;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Название задачи не может быть пустым");
                return;
            }

            Title = txtTitle.Text;
            Description = txtDescription.Text;
            IsCompleted = checkBoxIsCompleted.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

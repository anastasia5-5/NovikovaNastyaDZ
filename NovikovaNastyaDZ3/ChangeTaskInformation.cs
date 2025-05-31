namespace NovikovaNastyaDZ3
{
    public partial class ChangeTaskInformation : Form
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }
        public string Implementers { get; private set; }

        private readonly List<string> implementers_;

        public ChangeTaskInformation(TaskItem task, List<string> implementers)
        {
            InitializeComponent();
            implementers_ = implementers;
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            checkBoxIsCompleted.Checked = task.IsCompleted;
            comboBoxImplementers2.DataSource = implementers_;
            comboBoxImplementers2.SelectedItem = task.Implementer;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Title = txtTitle.Text;
            Description = txtDescription.Text;
            IsCompleted = checkBoxIsCompleted.Checked;
            Implementers = comboBoxImplementers2.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Название задачи не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return false;
            }

            if (comboBoxImplementers2.SelectedItem == null)
            {
                MessageBox.Show("Выберите исполнителя задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxImplementers2.Focus();
                return false;
            }

            return true;
        }
    }
}

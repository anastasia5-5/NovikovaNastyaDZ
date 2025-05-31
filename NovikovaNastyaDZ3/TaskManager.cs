
namespace NovikovaNastyaDZ3
{
    public partial class TaskManager : Form
    {
        private TaskManagerContext db;
        public TaskManager()
        {
            InitializeComponent();
            db = new TaskManagerContext();
            db.Database.EnsureCreated();
            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in db.Tasks.ToList())
            {
                string status = task.IsCompleted ? "[✓]" : "[ ]";
                listBoxTasks.Items.Add($"{status} {task.Title} (Исполнитель: {task.Implementer}, ID: {task.Id})");
            }
        }

        private readonly List<string> implementers = new() { "Федя Петров", "Мария Сидорова", "Катя Иванова" };

        private void TaskManager_Load(object sender, EventArgs e)
        {
            comboBoxImplementers.DataSource = implementers;
            comboBoxImplementers.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var newTask = new TaskItem
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                IsCompleted = false,
                Implementer = comboBoxImplementers.SelectedItem.ToString()
            };

            db.Tasks.Add(newTask);
            db.SaveChanges();

            txtTitle.Clear();
            txtDescription.Clear();
            RefreshTaskList();
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Название задачи не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus(); 
                return false;
            }

            if (comboBoxImplementers.SelectedItem == null)
            {
                MessageBox.Show("Выберите исполнителя задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxImplementers.Focus();
                return false;
            }

            return true; 
        }
        private void btnChangeTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                int selectedId = GetSelectedTaskId();
                var task = db.Tasks.Find(selectedId);
                var changeForm = new ChangeTaskInformation(task, implementers);
                if (changeForm.ShowDialog() == DialogResult.OK)
                {
                    task.Title = changeForm.Title;
                    task.Description = changeForm.Description;
                    task.IsCompleted = changeForm.IsCompleted;
                    task.Implementer = changeForm.Implementers;

                    db.SaveChanges();
                    RefreshTaskList();
                }
            }
        }
        private int GetSelectedTaskId()
        {
            string selectedItem = listBoxTasks.SelectedItem.ToString();
            int start = selectedItem.IndexOf("ID: ") + 4;
            int end = selectedItem.IndexOf(")", start);
            return int.Parse(selectedItem.Substring(start, end - start));
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                int selectedId = GetSelectedTaskId();
                var task = db.Tasks.Find(selectedId);

                if (task != null)
                {
                    db.Tasks.Remove(task);
                    db.SaveChanges();
                    RefreshTaskList();
                }
            }
        }
    }
}

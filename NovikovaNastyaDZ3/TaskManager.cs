using Microsoft.EntityFrameworkCore;
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
            var tasks = db.Tasks.ToList();

            foreach (var task in tasks)
            {
                string status = task.IsCompleted ? "[✓]" : "[ ]";
                listBoxTasks.Items.Add($"{status} {task.Title} (ID: {task.Id})");
            }
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                var newTask = new TaskItem
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    IsCompleted = false 
                };

                db.Tasks.Add(newTask);
                db.SaveChanges();

                txtTitle.Clear();
                txtDescription.Clear();
                RefreshTaskList();
            }          
            
        }

        private void btnChangeTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                int selectedId = GetSelectedTaskId();
                var task = db.Tasks.Find(selectedId);

                if (task != null)
                {
                    var changeTaskInformation = new ChangeTaskInformation(task);
                    if (changeTaskInformation.ShowDialog() == DialogResult.OK)
                    {
                        task.Title = changeTaskInformation.Title;
                        task.Description = changeTaskInformation.Description;
                        task.IsCompleted = changeTaskInformation.IsCompleted;

                        db.SaveChanges();
                        RefreshTaskList();
                    }
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

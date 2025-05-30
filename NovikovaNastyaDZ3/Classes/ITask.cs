
namespace NovikovaNastyaDZ3
{
    public interface ITask
    {
        Task<List<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> GetTaskByIdAsync(int id);
        Task AddTaskAsync(TaskItem task);
        Task DeleteTaskAsync(int id);
    }
}

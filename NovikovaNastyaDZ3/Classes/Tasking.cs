using Microsoft.EntityFrameworkCore;

namespace NovikovaNastyaDZ3
{
    public class Tasking : ITask
    {
        private readonly TaskManagerContext context;
        public Tasking(TaskManagerContext context)
        {
            this.context = context;
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await context.Tasks.ToListAsync();
        }

        public async Task<TaskItem> GetTaskByIdAsync(int id)
        {
            return await context.Tasks.FindAsync(id);
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            await context.Tasks.AddAsync(task);
            await context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            context.Tasks.Update(task);
            await context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await context.Tasks.FindAsync(id);
            if (task != null)
            {
                context.Tasks.Remove(task);
                await context.SaveChangesAsync();
            }
        }
    }
}

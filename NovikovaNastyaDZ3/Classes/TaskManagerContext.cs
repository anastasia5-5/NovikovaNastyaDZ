using Microsoft.EntityFrameworkCore;

namespace NovikovaNastyaDZ3
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TaskManagerDatabase.sqlite");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>()
                .ToTable("TaskManager")
            .HasKey(e => e.Id);
            modelBuilder.Entity<TaskItem>();
            modelBuilder.Entity<TaskItem>()
           .Property(e => e.Id)
           .ValueGeneratedOnAdd();
        }
    }
}

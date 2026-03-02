using Microsoft.EntityFrameworkCore;

public class TodoDb(DbContextOptions<TodoDb> opts) : DbContext(opts)
{
    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>().HasIndex(t => t.CreatedAt);
        modelBuilder.Entity<TodoItem>().HasIndex(t => t.IsCompleted);
    }
}

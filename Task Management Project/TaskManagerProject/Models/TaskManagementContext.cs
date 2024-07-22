using Microsoft.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore;

namespace TaskManagerProject.Models

{

    public class TaskManagementContext : DbContext

    {

        public DbSet<TaskManagementSystem.Task> Tasks { get; set; }

        public DbSet<TaskManagementSystem.Employee> Employees { get; set; }

        public DbSet<TaskManagementSystem.Team> Teams { get; set; }

        public DbSet<TaskManagementSystem.Note> Notes { get; set; }

        public DbSet<TaskManagementSystem.Document> Documents { get; set; }

        public TaskManagementContext(DbContextOptions<TaskManagementContext> options)

            : base(options)

        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskManagementSystem.Employee>()

                .HasOne(e => e.Team)

                .WithMany(t => t.Employees)

                .HasForeignKey(e => e.TeamId)

                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<TaskManagementSystem.Team>()

                .HasOne(t => t.Manager)

                .WithMany()

                .HasForeignKey(t => t.ManagerId)

                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<TaskManagementSystem.Task>()

                .HasOne(t => t.Employee)

                .WithMany(e => e.Tasks)

                .HasForeignKey(t => t.EmployeeId)

                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<TaskManagementSystem.Note>()

                .HasOne(n => n.Task)

                .WithMany(t => t.Notes)

                .HasForeignKey(n => n.TaskId)

                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<TaskManagementSystem.Document>()

                .HasOne(d => d.Task)

                .WithMany(t => t.Documents)

                .HasForeignKey(d => d.TaskId)

                .OnDelete(DeleteBehavior.ClientSetNull);

        }

    }

}

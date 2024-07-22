namespace TaskManagerProject.Models
{
    public class TaskManagementSystem
    {
        public class Task
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public bool IsCompleted { get; set; }
            public int EmployeeId { get; set; }
            public Employee Employee { get; set; }
            public ICollection<Note> Notes { get; set; } = new List<Note>();
            public ICollection<Document> Documents { get; set; } = new List<Document>();
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int TeamId { get; set; }
            public Team Team { get; set; }
            public ICollection<Task> Tasks { get; set; } = new List<Task>();
        }
        public class Team
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int? ManagerId { get; set; }
            public Employee Manager { get; set; }
            public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        }
        public class Note
        {
            public int Id { get; set; }
            public string Content { get; set; }
            public DateTime CreatedDate { get; set; }
            public int TaskId { get; set; }
            public Task Task { get; set; }
        }
        public class Document
        {
            public int Id { get; set; }
            public string FileName { get; set; }
            public byte[] Content { get; set; }
            public DateTime UploadedAt { get; set; }
            public int TaskId { get; set; }
            public Task Task { get; set; }
        }
    }
}
public class TodoItem
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; } = "";
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public UrgencyLevel Urgency { get; set; } = UrgencyLevel.None;
    public DateTime? CompleteBy { get; set; }
}

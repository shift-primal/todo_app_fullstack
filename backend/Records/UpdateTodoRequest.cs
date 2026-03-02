public record UpdateTodoRequest(
    string? Title,
    string? Description,
    UrgencyLevel? Urgency,
    DateTime? CompleteBy,
    bool? IsCompleted
);

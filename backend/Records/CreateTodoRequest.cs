public record CreateTodoRequest(
    string Title,
    string? Description,
    UrgencyLevel Urgency = UrgencyLevel.None,
    DateTime? CompleteBy = null
);

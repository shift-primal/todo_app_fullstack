public record TodoQuery(
    DateTime? From,
    DateTime? To,
    bool? IsCompleted,
    bool? IsUncompleted,
    string? Title,
    SortBy SortBy = SortBy.Date,
    SortDir SortDir = SortDir.Desc,
    int PageNumber = 1,
    int PageSize = 25
);

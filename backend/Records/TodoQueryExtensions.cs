using Microsoft.EntityFrameworkCore;

public static class TodoQueryExtensions
{
    public static IQueryable<TodoItem> Apply(this IQueryable<TodoItem> query, TodoQuery q)
    {
        if (q.From is not null)
            query = query.Where(t => t.CreatedAt >= q.From);
        if (q.To is not null)
            query = query.Where(t => t.CreatedAt <= q.To);
        if (q.IsCompleted is not null)
            query = query.Where(t => t.IsCompleted == q.IsCompleted);
        if (q.Search is not null)
            query = query.Where(t =>
                t.Title.ToLower().Contains(q.Search.ToLower())
                || (t.Description != null && t.Description.ToLower().Contains(q.Search.ToLower()))
            );

        return query;
    }

    public static IQueryable<TodoItem> Paginate(this IQueryable<TodoItem> query, TodoQuery q)
    {
        return query.Skip((q.PageNumber - 1) * q.PageSize).Take(q.PageSize);
    }

    public static IQueryable<TodoItem> Sort(this IQueryable<TodoItem> query, TodoQuery q)
    {
        return (q.SortBy, q.SortDir) switch
        {
            (SortBy.Name, SortDir.Asc) => query.OrderBy(t => t.Title),
            (SortBy.Name, SortDir.Desc) => query.OrderByDescending(t => t.Title),
            (SortBy.Date, SortDir.Asc) => query.OrderBy(t => t.CreatedAt),
            (SortBy.Date, SortDir.Desc) => query.OrderByDescending(t => t.CreatedAt),
            (SortBy.Status, SortDir.Asc) => query.OrderBy(t => t.IsCompleted),
            (SortBy.Status, SortDir.Desc) => query.OrderByDescending(t => t.IsCompleted),
            (SortBy.Urgency, SortDir.Asc) => query.OrderBy(t => t.Urgency),
            (SortBy.Urgency, SortDir.Desc) => query.OrderByDescending(t => t.Urgency),
            _ => query.OrderBy(t => t.Id),
        };
    }
}

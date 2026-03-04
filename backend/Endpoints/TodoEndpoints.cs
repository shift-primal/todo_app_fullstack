using Microsoft.EntityFrameworkCore;

public static class TodoEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet(
            "/todos",
            async (TodoDb db, [AsParameters] TodoQuery q) =>
            {
                var query = db.TodoItems.Apply(q).Sort(q);

                var totalCount = await query.CountAsync();

                var items = await query.Paginate(q).ToListAsync();

                return TypedResults.Ok(
                    new PagedResult<TodoItem>
                    {
                        Items = items,
                        TotalCount = totalCount,
                        TotalPages = (int)Math.Ceiling((double)totalCount / q.PageSize),
                        PageNumber = q.PageNumber,
                        PageSize = q.PageSize,
                    }
                );
            }
        );

        app.MapGet(
            "/todos/{id}",
            async (TodoDb db, int id) =>
            {
                var todo = await db.TodoItems.FindAsync(id);
                if (todo is null)
                    return Results.NotFound();

                return Results.Ok(todo);
            }
        );

        app.MapPost(
            "/todos",
            async (TodoDb db, CreateTodoRequest req) =>
            {
                var todo = new TodoItem
                {
                    Title = req.Title,
                    Description = req.Description,
                    Urgency = req.Urgency,
                    CompleteBy = req.CompleteBy,
                };
                db.Add(todo);
                await db.SaveChangesAsync();
                return Results.Created($"/todos/{todo.Id}", todo);
            }
        );

        app.MapPut(
            "/todos/{id}",
            async (TodoDb db, int id, UpdateTodoRequest req) =>
            {
                var todo = await db.TodoItems.FindAsync(id);
                if (todo is null)
                    return Results.NotFound();

                todo.Title = req.Title ?? todo.Title;
                todo.Description = req.Description ?? todo.Description;
                todo.Urgency = req.Urgency ?? todo.Urgency;
                todo.CompleteBy = req.CompleteBy ?? todo.CompleteBy;
                todo.IsCompleted = req.IsCompleted ?? todo.IsCompleted;

                await db.SaveChangesAsync();
                return Results.Ok(todo);
            }
        );

        app.MapDelete(
            "/todos/{id}",
            async (TodoDb db, int id) =>
            {
                var todo = await db.TodoItems.FindAsync(id);
                if (todo is null)
                    return Results.NotFound();

                db.TodoItems.Remove(todo);
                await db.SaveChangesAsync();
                return Results.Ok(todo);
            }
        );
    }
}

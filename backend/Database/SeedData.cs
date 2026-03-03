using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder mb)
    {
        mb.Entity<TodoItem>()
            .HasData(
                new
                {
                    Id = 1,
                    Title = "Buy groceries",
                    Description = "Milk, eggs, bread, butter, coffee",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 2, 16, 10, 14, 15, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 3, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 2,
                    Title = "Pay rent",
                    Description = "Transfer to landlord before end of month",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 2, 18, 18, 34, 14, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 31, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 3,
                    Title = "Clean the apartment",
                    Description = "Vacuum, mop floors, clean bathroom",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 2, 22, 17, 30, 19, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 4,
                    Title = "Finish portfolio site",
                    Description = "Add projects section and deploy to Vercel",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 2, 22, 18, 15, 13, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 10, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 5,
                    Title = "Call the dentist",
                    Description = "Book a checkup appointment",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 2, 22, 19, 20, 39, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 6,
                    Title = "Read Clean Code",
                    Description = "Finish chapters 4 through 7",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 2, 27, 15, 25, 22, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 7,
                    Title = "Reply to emails",
                    Description = "Job application follow-ups",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 3, 1, 19, 22, 49, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 8,
                    Title = "Fix bike tire",
                    Description = "Rear tire is flat, need a new inner tube",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 3, 1, 19, 24, 44, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 9,
                    Title = "Cancel gym membership",
                    Description = "Log in to their site and cancel subscription",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 3, 1, 19, 40, 33, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 5, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 10,
                    Title = "Water the plants",
                    Description = "",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.None,
                    CreatedAt = new DateTime(2026, 3, 2, 10, 45, 32, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 11,
                    Title = "Set up CI/CD pipeline",
                    Description = "GitHub Actions for the todo app",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 3, 2, 14, 50, 58, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 12,
                    Title = "Renew car insurance",
                    Description = "Compare prices before renewing",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 3, 2, 15, 55, 12, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 15, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 13,
                    Title = "Meal prep for the week",
                    Description = "Cook rice, chicken and vegetables for 5 days",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 3, 2, 15, 59, 32, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 14,
                    Title = "Update CV",
                    Description = "Add latest projects and skills",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 3, 2, 16, 04, 54, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 15,
                    Title = "Take out the trash",
                    Description = "",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.None,
                    CreatedAt = new DateTime(2026, 3, 2, 19, 12, 32, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                }
            );
    }
}

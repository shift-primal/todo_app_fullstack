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
                },
                new
                {
                    Id = 16,
                    Title = "Book flight for Christmas",
                    Description = "Check SAS and Norwegian before deciding",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 10, 2, 9, 17, 34, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2025, 11, 15, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 17,
                    Title = "Organize photos on hard drive",
                    Description = "Sort by year and delete duplicates",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 10, 4, 20, 33, 11, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 18,
                    Title = "Research standing desks",
                    Description = "Budget around 3000 NOK, check Flexispot and Ikea",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 10, 7, 21, 7, 58, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 19,
                    Title = "Call mom for her birthday",
                    Description = "",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2025, 10, 9, 18, 52, 23, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 20,
                    Title = "Fix leaking faucet in kitchen",
                    Description = "Might just need a new washer",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 10, 12, 11, 44, 7, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 21,
                    Title = "Renew passport",
                    Description = "Expires in spring, book at the police station",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2025, 10, 15, 9, 28, 16, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 22,
                    Title = "Back up laptop",
                    Description = "Full backup to external drive and iCloud",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 10, 19, 22, 3, 41, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 23,
                    Title = "Read Atomic Habits",
                    Description = "Already at chapter 3",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 10, 21, 20, 15, 29, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 24,
                    Title = "Return library books",
                    Description = "Two books overdue, check fines",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 10, 24, 13, 37, 52, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2025, 10, 25, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 25,
                    Title = "Buy winter jacket",
                    Description = "Check Fjallraven and Bergans",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 10, 28, 17, 22, 18, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 26,
                    Title = "Set up new work laptop",
                    Description = "Install dev tools, clone repos, set up SSH keys",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2025, 11, 1, 14, 11, 43, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 27,
                    Title = "Clean out wardrobe",
                    Description = "Donate clothes I haven't worn in a year",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 11, 3, 19, 48, 27, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 28,
                    Title = "Write thank you notes",
                    Description = "After the dinner last weekend",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.None,
                    CreatedAt = new DateTime(2025, 11, 6, 21, 54, 9, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 29,
                    Title = "Budget for Christmas gifts",
                    Description = "Set a limit per person and make a list",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 11, 9, 10, 37, 44, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2025, 12, 1, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 30,
                    Title = "Book eye appointment",
                    Description = "Vision has been blurry, probably need new glasses",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 11, 12, 8, 19, 33, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 31,
                    Title = "Learn Docker basics",
                    Description = "Containers, volumes, compose — go through the docs",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 11, 15, 22, 41, 17, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 32,
                    Title = "Defrost freezer",
                    Description = "",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.None,
                    CreatedAt = new DateTime(2025, 11, 18, 16, 27, 55, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 33,
                    Title = "Fix broken shelf in bedroom",
                    Description = "One bracket has come loose from the wall",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 11, 20, 11, 8, 22, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 34,
                    Title = "Cancel unused subscriptions",
                    Description = "Audible, some random app — check bank statement",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 11, 23, 20, 53, 31, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 35,
                    Title = "Update phone software",
                    Description = "",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.None,
                    CreatedAt = new DateTime(2025, 11, 27, 9, 14, 48, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 36,
                    Title = "Buy Christmas gifts",
                    Description = "Mom, dad, sister, two friends — check the list",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2025, 12, 1, 19, 31, 26, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2025, 12, 22, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 37,
                    Title = "Send Christmas cards",
                    Description = "Old-fashioned physical cards this year",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 12, 4, 21, 7, 14, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2025, 12, 20, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 38,
                    Title = "Book New Year plans",
                    Description = "Figure out if we're going to the cabin or staying in town",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 12, 8, 17, 43, 52, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 39,
                    Title = "Write year in review",
                    Description = "Goals met, lessons learned, what to focus on next year",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 12, 15, 22, 19, 37, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 40,
                    Title = "Arrange secret Santa gift",
                    Description = "Theme is self-care, budget 200 NOK",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2025, 12, 17, 14, 55, 28, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2025, 12, 19, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 41,
                    Title = "Update renters insurance",
                    Description = "Got new electronics, need to update coverage value",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 12, 19, 10, 22, 43, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 42,
                    Title = "Fix broken headphones",
                    Description = "Left ear is cutting out, probably the cable",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 12, 22, 15, 38, 11, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 43,
                    Title = "Get haircut before Christmas",
                    Description = "",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2025, 12, 23, 11, 27, 39, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 44,
                    Title = "Plan January workout routine",
                    Description = "3 days a week, mix of running and lifting",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2025, 12, 28, 20, 14, 56, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 45,
                    Title = "Set up 2026 budget spreadsheet",
                    Description = "Monthly income, fixed expenses, savings goal",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 1, 2, 14, 33, 17, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 46,
                    Title = "Research new laptop",
                    Description = "Current one is struggling with running VMs",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 1, 5, 21, 48, 2, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 47,
                    Title = "Fix sleep schedule",
                    Description = "Stop going to bed past 01:00, aim for 23:00",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 1, 8, 22, 57, 44, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 48,
                    Title = "Apply for job at Bekk",
                    Description = "Tailor CV and write a cover letter",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 1, 12, 19, 21, 38, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 1, 31, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 49,
                    Title = "Clean out email inbox",
                    Description = "Unsubscribe from newsletters, archive old threads",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 1, 16, 9, 43, 27, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 50,
                    Title = "Update LinkedIn profile",
                    Description = "New profile photo and update projects section",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 1, 19, 20, 7, 15, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 51,
                    Title = "Learn Rust basics",
                    Description = "Go through the Rust Book, at least chapters 1-6",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 1, 22, 22, 34, 51, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 52,
                    Title = "Buy new running shoes",
                    Description = "Old Nikes are done, look at Brooks or Asics",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 1, 26, 13, 58, 29, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 53,
                    Title = "Organize notes from last year",
                    Description = "Move Notion notes into a proper folder structure",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 1, 29, 19, 12, 44, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 54,
                    Title = "Write blog post about EF Core",
                    Description = "Cover migrations, seeding, and owned entities",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 2, 2, 21, 27, 33, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 55,
                    Title = "Learn TypeScript generics",
                    Description = "Specifically conditional types and infer keyword",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 2, 5, 20, 44, 19, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 56,
                    Title = "Fix bedroom light fixture",
                    Description = "Bulb keeps flickering, probably a loose connection",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 2, 8, 17, 53, 27, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 57,
                    Title = "Buy birthday gift for Marte",
                    Description = "She mentioned wanting a book or skincare",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 2, 11, 12, 18, 43, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 2, 14, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 58,
                    Title = "Organize project files",
                    Description = "Clean up the repos folder, delete old test projects",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 2, 14, 21, 35, 8, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 59,
                    Title = "Research apartments in the city",
                    Description = "Check Finn.no, set up alerts for desired neighborhoods",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 2, 17, 19, 22, 37, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 60,
                    Title = "Set up daily meditation habit",
                    Description = "10 minutes in the morning, try Waking Up app",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 2, 19, 7, 41, 52, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 61,
                    Title = "Write unit tests for todo API",
                    Description = "Cover all endpoints, at least happy path + 404 cases",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 2, 21, 21, 17, 44, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 62,
                    Title = "Fix failing CI pipeline",
                    Description = "Tests pass locally but fail in GitHub Actions",
                    IsCompleted = true,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 2, 23, 11, 33, 22, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 63,
                    Title = "Book car for service",
                    Description = "Annual service is overdue by about 2000 km",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Medium,
                    CreatedAt = new DateTime(2026, 2, 25, 14, 47, 19, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 15, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 64,
                    Title = "Submit tax documents",
                    Description = "Gather all receipts and log into Skatteetaten",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 2, 27, 20, 28, 51, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 4, 30, 0, 0, 0, DateTimeKind.Utc),
                },
                new
                {
                    Id = 65,
                    Title = "Order new mechanical keyboard",
                    Description = "Looking at Keychron K2 or Q1",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 3, 1, 18, 14, 37, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 66,
                    Title = "Declutter storage room",
                    Description = "Haven't touched half that stuff in two years",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.Low,
                    CreatedAt = new DateTime(2026, 3, 2, 22, 8, 44, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)null,
                },
                new
                {
                    Id = 67,
                    Title = "Prep for job interview",
                    Description = "Review system design basics and common React questions",
                    IsCompleted = false,
                    Urgency = UrgencyLevel.High,
                    CreatedAt = new DateTime(2026, 3, 3, 9, 47, 22, DateTimeKind.Utc),
                    CompleteBy = (DateTime?)new DateTime(2026, 3, 5, 0, 0, 0, DateTimeKind.Utc),
                }
            );
    }
}

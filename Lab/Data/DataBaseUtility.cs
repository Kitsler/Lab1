using Microsoft.EntityFrameworkCore;

 namespace Lab.Data;
 public static class DatabaseUtility
 {
    public static async Task EnsureDbCreatedAndSeedAsync(DbContextOptions<StipContext> options)
    {
        var factory = new LoggerFactory();
        var builder = new DbContextOptionsBuilder<StipContext>(options).UseLoggerFactory(factory);

        using var context = new StipContext(builder.Options);
        if (await context.Database.EnsureCreatedAsync())
            {
                var seed = new SeedData();
                await seed.InitialyzeAsync(context);
            }
    }
 }

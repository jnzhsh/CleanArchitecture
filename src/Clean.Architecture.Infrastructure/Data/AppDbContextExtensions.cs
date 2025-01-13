namespace Clean.Architecture.Infrastructure.Data;

public static class AppDbContextExtensions
{
  public static void AddApplicationDbContext(this IServiceCollection services, string connectionString) =>
    services.AddDbContext<xxxxDbContext>(options =>
         options.UseSqlite(connectionString));

}

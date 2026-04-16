using TPI_2026.Shared;

namespace TPI_2026.TestAppHost;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = DistributedApplication.CreateBuilder(args);

        builder
            .AddSqlite(Services.Database);

        builder.Build().Run();
    }
}
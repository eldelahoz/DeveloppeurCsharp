using CA.MigratorDB.Main;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hi");
    }

    public static IConfiguration LoadConfiguration()
    {
        var builder = new ConfigurationBuilder();
        return builder.Build();
    }

    private static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        var config = LoadConfiguration();
        services.AddSingleton(config);
        services.Add
        services.Configure<ConnectionStringCollection>(options => config.GetSection($"CollectionConnectionStrings").Bind(options));
    }
}

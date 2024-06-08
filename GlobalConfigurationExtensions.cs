public static class GlobalConfigurationExtensions
{
    public static IConfiguration<ClassToConfigure> AddLogging(
        this IConfiguration<ClassToConfigure> configuration)
    {
        configuration.Entry._services.AddLogging(x => x.AddConsole());

        return configuration;
    }
}
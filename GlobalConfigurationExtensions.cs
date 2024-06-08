public static class GlobalConfigurationExtensions
{
    public static ClassToConfigure AddLogging(
        this ClassToConfigure configuration)
    {
        configuration._services.AddLogging(x => x.AddConsole());

        return configuration;
    }
}
public class ClassToConfigure
{
    internal ServiceCollection _services = new ServiceCollection();

    public ClassToConfigure(Action<ClassToConfigure> configure)
    {

        _services.AddSingleton<IGlobalConfiguration>(provider =>
        {
            var configInstance = GlobalConfiguration.configurationInstance;

            configure(this);

            return configInstance;
        });

    }

}
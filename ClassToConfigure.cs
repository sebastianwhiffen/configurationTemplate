public class ClassToConfigure
{
    internal ServiceCollection _services = new ServiceCollection();

    public ClassToConfigure(Action<IConfiguration<ClassToConfigure>> configure)
    {
        var instance = new Configuration<ClassToConfigure>(this);

        _services.AddSingleton<IGlobalConfiguration>();

        configure(instance);
    }

}
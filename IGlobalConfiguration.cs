public interface IGlobalConfiguration { }

public interface IConfiguration<out T> : IGlobalConfiguration
{
    T Entry { get; }
}

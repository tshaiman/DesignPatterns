

namespace InterfaceSegregation.Configuration1
{
    public interface IAppSettings
    {
        string ApplicationName { get;  }
        string AuthorName { get;  }
    }

    public interface IDatabaseSettings
    {
        // data access settings
        string DatabaseServerName { get; }
        string DatabaseName { get; }
        string DatabaseUserName { get; }
        string DatabasePassword { get; }
    }

    public interface IConfigurationSettings : IAppSettings, IDatabaseSettings
    {
        // performance tuning settings
        int CacheDuration { get; }
        // web service api settings
        string WebServiceBaseUri { get; }

    }
}
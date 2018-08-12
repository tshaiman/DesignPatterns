using System.IO;
using InterfaceSegregation.Configuration1;

namespace InterfaceSegregation.Configuration2
{
    public class AboutPage
    {
        private readonly IAppSettings _appSettings;

        public AboutPage(IAppSettings configurationSettings)
        {
            _appSettings = configurationSettings;
        }
        
        public AboutPage() : this(ConfigurationSettings.Settings)
        {}

        public void Render(TextWriter writer)
        {
            //todo : right implementation
            writer.Write("{0} By {1}", _appSettings.ApplicationName, _appSettings.AuthorName);
        }
    }
}
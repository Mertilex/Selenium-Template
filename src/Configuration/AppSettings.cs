using Microsoft.Extensions.Configuration;

namespace Configuration
{
    public static class AppSettings
    {
        private static readonly IConfigurationRoot Config;

        public static string Test => Config["Key0"];

        static AppSettings()
        {
            Config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                    .Build();
        }
    }
}

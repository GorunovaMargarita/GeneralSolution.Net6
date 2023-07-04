using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace QaseIOAPITests.Configuration
{
    public class Configurator
    {
        public static APIConfiguration API => BindConfiguration<APIConfiguration>();
        public static IConfigurationRoot configurationRoot;

        static Configurator()
        {
            configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
        }

        private static T BindConfiguration<T>() where T : IConfiguration, new()
        {
            var config = new T();
            configurationRoot.GetSection(config.SectionName).Bind(config);
            return config;
        }

        public static string GetValue(string key)
        {
            return configurationRoot[key];
        }
    }
}

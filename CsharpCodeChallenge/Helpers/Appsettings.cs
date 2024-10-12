
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;

namespace CsharpCodeChallenge.Helpers
{
    public class Appsettings
    {
        public static string? _connectionDbSqlServer;
        public static void Init()
        {
            var configurationBuilder = new ConfigurationBuilder();                         

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            IConfigurationRoot root = configurationBuilder.Build();

            _connectionDbSqlServer = root.GetSection("ConnectionStrings").GetSection("Dev").Value;
        }

        public static string? ConnectionDbSqlServer()
        {
            return _connectionDbSqlServer;
        }
    }
}

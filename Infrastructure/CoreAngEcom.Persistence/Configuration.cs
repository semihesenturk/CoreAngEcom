using Microsoft.Extensions.Configuration;

namespace CoreAngEcom.Persistence
{
    static class Configuration
	{
		public static string ConnectionString
        {
			get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/CoreAngEcom.Api"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
	}
}


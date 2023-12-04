using System;
namespace LRS_Razor.Helpers
{
	public class ConfigurationHelper
	{
        private static IConfiguration _configuration;
        private static IHttpContextAccessor _contextAccessor;
        public static void Initialize(IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            _configuration = configuration;
            _contextAccessor = contextAccessor;

        }

        public static string DefaultConnection => _configuration["ConnectionStrings:DefaultConnection"];

    }
}


using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Repository
{
    public static class DataConnect
    {
        public static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:BankAccountTypeDB"];
            return strConn;
        }
    }
}

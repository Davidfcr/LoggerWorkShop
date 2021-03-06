﻿namespace LoggerElasticSearch
{
    #region usings
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}

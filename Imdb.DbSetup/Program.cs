using System;
using System.Configuration;
using DbUp;
using System.Reflection;
using System.IO;

namespace Imdb.DbSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            EnsureDatabase.For.SqlDatabase(connectionString);
            var dbDeployment = DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsFromFileSystem(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Scripts"))
                .LogToConsole()
                .Build();
            var result = dbDeployment.PerformUpgrade();
            if (!result.Successful)
            {
                throw new Exception("Db Set up failed");
            }
        }
    }
}

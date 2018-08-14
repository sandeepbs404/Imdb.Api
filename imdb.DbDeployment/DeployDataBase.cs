using DbUp;
using System;
using System.IO;
using System.Reflection;

namespace imdb.DbDeployment
{
    public class DeployDataBase
    {
        public static void Deploy(string connectionString)
        {
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

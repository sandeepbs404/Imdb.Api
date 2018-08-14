using System.Configuration;
using imdb.DbDeployment;

namespace Imdb.DbSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            DeployDataBase.Deploy(connectionString);
        }
    }
}

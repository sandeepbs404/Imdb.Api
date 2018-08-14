using NUnit.Framework;
using RimDev.Automation.Sql;
using imdb.DbDeployment;
namespace Imdb.BusinessLogic.UnitTests
{
    [SetUpFixture]
    public class TestSetUp
    {
        private static LocalDb testDb;
        public static string ConnectionString { private set; get; }
        [OneTimeSetUp]
        public void SetUp()
        {
            testDb = new LocalDb("imdbTest","v13.0");
            ConnectionString = testDb.ConnectionString;
            DeployDataBase.Deploy(testDb.ConnectionString);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            testDb.Dispose();
        }

        public void Dispose()
        {
            if (testDb.IsAttached())
            {
                testDb.Dispose();
            }
        }
    }
}

using Dapper;
using Imdb.BusinessLogic.ManageCrew;
using NUnit.Framework;
using System;
using System.Data.SqlClient;

namespace Imdb.BusinessLogic.UnitTests.ManageCrew
{
    [TestFixture]
    public class ManageCrewUnitTest
    {
        [Test]
        public void CrewCommandHandler_CreateCrew_Given_ValidData()
        {
            var addCrewCommand = new AddCrewCommand
            {
                Name = "Actor1",
                Sex = "Male",
                Bio = "Know for xyz",
                DateOfBirth = DateTime.Now,
                RoleId = Common.RoleEnum.Actor
            };

            var cmd = new CrewCommandHandler();
            cmd.AddCrew(addCrewCommand);
            using(var con = new SqlConnection(TestSetUp.ConnectionString))
            {
                //var result = con.Query("SELECT * ")
            }

            //TestSetUp.ConnectionString
        }

        
    }
}

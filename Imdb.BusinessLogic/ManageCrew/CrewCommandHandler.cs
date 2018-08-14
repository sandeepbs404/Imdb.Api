using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Imdb.BusinessLogic.ManageCrew
{
    public class CrewCommandHandler
    {
        private const string _insertCrewScript = @"INSERT INTO [dbo].[Person]
           ([Name]
           ,[Sex]
           ,[DateofBirth]
           ,[Bio]
           ,[ModifiedOn]
           ,[ModifiedBy])
     VALUES
           (@Name
           ,@Sex
           ,@DateOfBirth
           ,@Bio
           ,getdate()
           ,'Admin');

            INSERT INTO [dbo].[PersonDetail]
           ([PersonId]
           ,[RoleId]
           ,[ModifiedOn]
           ,[ModifiedBy])
     VALUES
           (SELECT SCOPE_IDENTITY() 
           ,@RoleId
           ,getDate()
           ,@ModifiedBy)";
        public void AddCrew(AddCrewCommand command)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(_insertCrewScript, new
                {
                    command.Name,
                    command.Sex,
                    command.DateOfBirth,
                    command.Bio,
                    ModifiedBy = "Admin",
                    command.RoleId
                });
            }
        }
    }
}

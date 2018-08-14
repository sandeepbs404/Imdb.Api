using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Imdb.BusinessLogic.ManageCrew
{
    public class GetCrewQueryProcessor
    {
        private const string query = @"
select p.*,r.Id as RoleId, r.Description from PersonDetail d 
LEFT JOIN Role r ON r.Id= d.RoleId
LEFT JOIN Person p ON p.Id = d.PersonId WHERE (@roleId IS NOT NULL AND r.Id = @roleId) OR @roleId IS NULL   
";
        public void ProcessQuery(GetCrewQuery query)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                //var crew = connection.Query<PersonDetails, Person, Role>(query,(Person))
            }
        }
    }
}

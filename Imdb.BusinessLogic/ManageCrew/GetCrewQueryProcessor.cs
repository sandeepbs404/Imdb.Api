using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Imdb.BusinessLogic.ManageCrew
{
    public class GetCrewQueryProcessor
    {
        private const string query = @"
            select * from PersonDetail d 
            LEFT JOIN Role r ON r.Id= d.RoleId
            LEFT JOIN Person p ON p.Id = d.PersonId";
        public IList<Person> ProcessQuery(GetCrewQuery query)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var crew = connection.Query<PersonDetails, Person, Role>(query,(Person))
            }
        }
    }
}

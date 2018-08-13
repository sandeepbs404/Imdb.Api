using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imdb.BusinessLogic
{
    public class ManagePerson
    {
        public ManagePerson()
        {

        }

        public void AddPerson()
        {

        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Bio { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DateOfRelease { get; set; }
    }

    public class PersonDetails
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PersonId { get; set; }
    }

    public class Crew
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int PersonDetails_id { get; set; }
    }
}

using Imdb.BusinessLogic.Common;
using System;

namespace Imdb.BusinessLogic.ManageCrew
{
    public class AddCrewCommand
    {
        public string Name;
        public string Sex;
        public DateTime DateOfBirth;
        public string Bio;
        public RoleEnum RoleId;
    }
}

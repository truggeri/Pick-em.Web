using System;

namespace Pick_em.Lib.Models
{
    public class TeamModel : BaseModel
    {
        public string Name;
        public string PrimaryColor;
        public string SecondaryColor;
        public Guid League;
    }
}
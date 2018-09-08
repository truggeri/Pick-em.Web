using System;

namespace Pick_em.Lib.Models
{
    public class SeasonModel : BaseModel
    {
        public string Name;
        public Guid League;
        public bool IsActive;
    }
}
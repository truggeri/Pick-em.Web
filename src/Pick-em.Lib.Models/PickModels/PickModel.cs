using System;

namespace Pick_em.Lib.Models
{
    public class PickModel : BaseModel
    {
        public Guid Game;
        public bool PickedHomeTeam;
        // Standin for UserId at the moment
        public Guid Picker;
    }
}
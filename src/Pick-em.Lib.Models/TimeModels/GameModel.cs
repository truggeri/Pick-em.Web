using System;

namespace Pick_em.Lib.Models
{
    public class GameModel : BaseModel
    {
        public Guid HomeTeam;
        public Guid AwayTeam;
        public Guid GameDay;
        public GameWinner Winner;
        public bool Played;
        public DateTime StartTime;
    }

    public enum GameWinner { Home, Away, Tie}
}
using System;

namespace Pick_em.Lib.Models
{
    public class GameModel : BaseModel
    {
        public TeamModel HomeTeam;
        public TeamModel AwayTeam;
        public GameDayModel GameDay;
        public GameWinner Winner;
        public bool Played;
        public DateTime StartTime;
    }

    public enum GameWinner { Home, Away, Tie}
}
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain
{
    /// <summary>
    /// A league which is a collection of teams that will play a season.
    /// </summary>
    public class League
    {
        private LeagueModel model { get; }

        /// <summary>
        /// Creates a new league.
        /// </summary>
        /// <param name="givenModel"> The LeagueModel that holds data about this team.</param>
        public League(LeagueModel givenModel)
        {
            this.model = givenModel;
        }
    }
}
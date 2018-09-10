using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain
{
    /// <summary>
    /// A team.
    /// </summary>
    public class Team
    {
        private TeamModel model { get; }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="givenModel"> The TeamModel that holds data about this team.</param>
        public Team(TeamModel givenModel)
        {
            this.model = givenModel;
        }
    }
}
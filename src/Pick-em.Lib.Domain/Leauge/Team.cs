using System;

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

        /// <summary>
        /// The primary team color.
        /// </summary>
        public string PrimaryColor {
            get { return this.model.PrimaryColor; }
            set { this.model.PrimaryColor = value; }
        }

        /// <summary>
        /// The secondary team color.
        /// </summary>
        public string SecondaryColor {
            get { return this.model.SecondaryColor; }
            set { this.model.SecondaryColor = value; }
        }

        /// <summary>
        /// Gives the Id of the underlying model.
        /// </summary>
        /// <returns>
        /// Guid that represents the underlying model.
        /// </returns>
        internal Guid GetId()
        {
            return this.model.Id;
        }

        /// <summary>
        /// Adds a reference to the given League to this Team.
        /// </summary>
        /// <param name="league">The League that this Team belongs to.</param>
        public void AddToLeague(League league)
        {
            this.model.League = league.GetId();
            league.teams.Add(this);
        }
    }
}
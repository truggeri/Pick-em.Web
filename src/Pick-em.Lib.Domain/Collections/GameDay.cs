using System;
using System.Collections.Generic;
using System.Linq;

using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain
{
    /// <summary>
    /// A cross league matchup window. Most American sports leagues
    ///  perform this in a week.
    /// </summary>
    public class GameDay
    {
        /// <summary>
        /// The GameDayModel that represents the GameDay.
        /// <summary>
        private GameDayModel model { get; }

        /// <summary>
        /// Collection of games to be played during the GameDay period.
        /// </summary>
        internal List<Game> games { get; }

        /// <summary>
        /// Creates an new empty GameDay.
        /// </summary>
        /// <param name="givenModel">The GameDayModel that holds data about this GameDay.</param>
        public GameDay(GameDayModel givenModel)
        {
            this.model = givenModel;
            this.games = new List<Game>();
        }

        /// <summary>
        /// Indicates if a GameDay is over (all games have been played)
        /// </summary>
        public bool Complete {
            get
            {
                bool unPlayedGames = !this.games
                        .Select(game => game.Played)
                        .Where(played => !played)
                        .Any();
                return this.games.Any() && unPlayedGames;
            }
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
    }
}
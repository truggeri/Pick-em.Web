using System;
using System.Runtime.CompilerServices;

using Pick_em.Lib.Models;

[assembly:InternalsVisibleTo("Pick-em.Lib.Domain.Test")]
namespace Pick_em.Lib.Domain
{
    /// <summary>
    /// A single game.
    /// </summary>
    public class Game
    {
        private GameModel model { get; }
        
        /// <summary>
        /// Creates a new game given two teams.
        /// </summary>
        /// <param name="givenModel"> The GameModel that holds data about this game.</param>
        public Game (GameModel givenModel)
        {
            this.model = givenModel;
        }

        /// <summary>
        /// Indicates if the game is complete.
        /// </summary>
        public bool Played {
            get
            {
                return (DateTime.Compare(this.model.StartTime, DateTime.UtcNow) < 0);
            } 
        }

        /// <summary>
        /// Gives the winner of the game or null if no outright winner.
        /// </summary>
        public Guid? Winner { 
            get
            {
                if (this.Played)
                {
                    if (this.model.Winner == GameWinner.Home)
                        return this.model.HomeTeam;
                    else if (this.model.Winner == GameWinner.Away)
                        return this.model.AwayTeam;
                }
                return null;
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
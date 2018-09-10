using System;

using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain
{
    public class Pick
    {
        private PickModel model { get; }

        /// <summary>
        /// Creates a new pick.
        /// </summary>
        /// <param name="givenModel"> The PickModel that holds data about this Pick.</param>
        public Pick(PickModel givenModel)
        {
            this.model = givenModel;
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
        /// Adds a reference to the given Game to this Pick.
        /// </summary>
        /// <param name="game">The Game that this Pick belongs to.</param>
        public void AssignGame(Game game)
        {
            this.model.Game = game.GetId();
        }
    }
}
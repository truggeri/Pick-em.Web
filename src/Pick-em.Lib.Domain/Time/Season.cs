using System;
using System.Collections.Generic;
using System.Linq;

using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain
{
    /// <summary>
    /// Season of a league.
    /// </summary>
    public class Season
    {
        /// <summary>
        /// The SeasonModel that represents the Season.
        /// <summary>
        private SeasonModel model { get; }

        /// <summary>
        /// Pointer to the current GameDay of the season.
        /// </summary>
        private int gameDayPointer { get; set; }

        /// <summary>
        /// Determines if the season is currently being played.
        /// </summary>
        private SeasonState state { get; set; }

        /// <summary>
        /// Collection of GameDays that compose the season.
        /// </summary>
        internal List<GameDay> gameDays { get; }

        /// <summary>
        /// Creates a new empty season.
        /// </summary>
        public Season(SeasonModel givenModel)
        {
            this.model = givenModel;
            this.gameDays = new List<GameDay>();
            this.gameDayPointer = 0;
            this.state = SeasonState.NotStarted;
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
        /// Advances the season to the next GameDay if it's active.
        /// </summary>
        /// <returns>
        /// True if the current GameDay was advanced.
        /// </returns>
        public bool Advance()
        {
            switch (this.state)
            {
                case SeasonState.NotStarted:
                    if (this.gameDays.Any())
                    {
                        this.state = SeasonState.InProgress;
                        return true;
                    }
                    else
                        return false;
                case SeasonState.InProgress:
                    if (++this.gameDayPointer >= this.gameDays.Count)
                    {
                        this.state = SeasonState.Complete;
                        return true;
                    }
                    return true;
                case SeasonState.Complete:
                    return false; 
            }
            return false;
        }
    }

    /// <summary>
    /// Enumeration of a Season.
    /// </summary>
    public enum SeasonState { NotStarted, InProgress, Complete }
}
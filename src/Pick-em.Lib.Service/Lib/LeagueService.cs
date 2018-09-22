using System;
using Microsoft.Extensions.Logging;
using Pick_em.Lib.Models;
using Pick_em.Lib.Domain;

namespace Pick_em.Lib.Service
{
    public class LeagueService
    {
        private ILogger logger { get; }

        public LeagueService
        (
            ILogger givenLogger
        )
        {
            this.logger = givenLogger;
        }

        public bool CreateLeague(LeagueModel model)
        {
            //@TODO data validation

            var league = new League(model);
            logger.LogDebug($"Created league with name {model.Name}");

            //@TODO save league

            return true;
        }
    }
}

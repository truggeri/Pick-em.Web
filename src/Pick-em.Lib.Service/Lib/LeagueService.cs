using System;
using Microsoft.Extensions.Logging;

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
    }
}

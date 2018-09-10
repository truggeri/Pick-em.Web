using System;
using System.Collections.Generic;
using Xunit;

using Pick_em.Lib.Domain;
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain.Test
{
    public class TeamTest
    {
        private Guid uniqueGuid = Guid.NewGuid();
        private TeamModel model { get; set; }
        private Team dut { get; set; }

        public TeamTest()
        {
            this.model = new TeamModel()
            { 
                Id = uniqueGuid
            };
            this.dut = new Team(this.model);
        }
    }
}
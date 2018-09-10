using System;
using System.Collections.Generic;
using Xunit;

using Pick_em.Lib.Domain;
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain.Test
{
    public class LeagueTest
    {
        private Guid uniqueGuid = Guid.NewGuid();
        private LeagueModel model { get; set; }
        private League dut { get; set; }

        public LeagueTest()
        {
            this.model = new LeagueModel()
            { 
                Id = uniqueGuid
            };
            this.dut = new League(this.model);
        }

        [Fact]
        public void TestId_WhenCalled_GivesGuid()
        {
            // Guid result = this.dut.GetId();
            // Assert.True(result.Equals(uniqueGuid));
        }
    }
}
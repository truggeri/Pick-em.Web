using System;
using System.Collections.Generic;
using Xunit;

using Pick_em.Lib.Domain;
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain.Test
{
    public class PickTest
    {
        private Guid uniqueGuid = Guid.NewGuid();
        private PickModel model { get; set; }
        private Pick dut { get; set; }

        public PickTest()
        {
            this.model = new PickModel()
            { 
                Id = uniqueGuid
            };
            this.dut = new Pick(this.model);
        }

        [Fact]
        public void TestId_WhenCalled_GivesGuid()
        {
            Guid result = this.dut.GetId();
            Assert.True(result.Equals(uniqueGuid));
        }

        [Fact]
        public void TestChoice_WhenHome_ThenTrue()
        {
            this.dut.Choice = PickChoice.HomeTeam;
            bool result = this.model.PickedHomeTeam;
            Assert.True(result);
        }

        [Fact]
        public void TestChoice_WhenAway_ThenFalse()
        {
            this.dut.Choice = PickChoice.AwayTeam;
            bool result = this.model.PickedHomeTeam;
            Assert.False(result);
        }

        [Fact]
        public void TestAssignGame_WhenGiven_ThenUpdated()
        {
            Guid expected = Guid.NewGuid();
            GameModel gModel = new GameModel() {
                Id = expected
            };
            Game g = new Game(gModel);
            
            this.dut.AssignGame(g);

            Assert.True(expected.Equals(this.model.Game));
        }
    }
}
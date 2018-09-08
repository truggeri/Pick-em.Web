using System;
using Xunit;

using Pick_em.Lib.Domain;
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain.Test
{
    public class GameTest
    {
        private GameModel model { get; set; }
        private Game dut { get; set; }

        public GameTest()
        {
            this.model = new GameModel()
            { 
                HomeTeam = new TeamModel() { Name = "HomeTeam" },
                AwayTeam = new TeamModel() { Name = "AwayTeam" }
            };
            this.dut = new Game(this.model);
        }

        [Fact]
        public void TestPlayed_WhenPlayed_ThenTrue()
        {
            this.model.StartTime = DateTime.UtcNow.AddMinutes(-1);
            bool result = this.dut.Played;
            Assert.True(result);
        }

        [Fact]
        public void TestPlayed_WhenNotPlayed_ThenFalse()
        {
            this.model.StartTime = DateTime.UtcNow.AddMinutes(1);
            bool result = this.dut.Played;
            Assert.False(result);
        }

        [Fact]
        public void TestWinner_WhenNotPlayed_ThenNull()
        {
            this.model.StartTime = DateTime.UtcNow.AddMinutes(1);
            TeamModel result = this.dut.Winner;
            Assert.Null(result);
        }

        [Fact]
        public void TestWinner_WhenHomeWins_ThenHome()
        {
            this.model.Winner = GameWinner.Home;
            this.model.StartTime = DateTime.UtcNow.AddMinutes(-1);
            TeamModel result = this.dut.Winner;
            Assert.NotNull(result);
            Assert.True(result.Equals(this.model.HomeTeam));
        }

        [Fact]
        public void TestWinner_WhenAwayWins_ThenAway()
        {
            this.model.Winner = GameWinner.Away;
            this.model.StartTime = DateTime.UtcNow.AddMinutes(-1);
            TeamModel result = this.dut.Winner;
            Assert.NotNull(result);
            Assert.True(result.Equals(this.model.AwayTeam));
        }

        [Fact]
        public void TestWinner_WhenTie_ThenNull()
        {
            this.model.Winner = GameWinner.Tie;
            this.model.StartTime = DateTime.UtcNow.AddMinutes(-1);
            TeamModel result = this.dut.Winner;
            Assert.Null(result);
        }
    }
}

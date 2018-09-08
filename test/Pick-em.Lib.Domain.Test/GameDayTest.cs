using System;
using System.Collections.Generic;
using Xunit;

using Pick_em.Lib.Domain;
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain.Test
{
    public class GameDayTest
    {
        private Guid uniqueGuid = Guid.NewGuid();
        private GameDayModel model { get; set; }
        private GameDay dut { get; set; }

        public GameDayTest()
        {
            this.model = new GameDayModel()
            { 
                Id = uniqueGuid
            };
            this.dut = new GameDay(this.model);
        }

        private Game getPastGame()
        {
            GameModel gm = new GameModel();
            gm.StartTime = DateTime.UtcNow.AddDays(-1);
            return new Game(gm);
        }

        private Game getFutureGame()
        {
            GameModel gm = new GameModel();
            gm.StartTime = DateTime.UtcNow.AddDays(1);
            return new Game(gm);
        }

        [Fact]
        public void TestId_WhenCalled_GivesGuid()
        {
            Guid result = this.dut.GetId();
            Assert.True(result.Equals(uniqueGuid));
        }

        [Fact]
        public void TestComplete_WhenAllPlayed_ThenTrue()
        {
            List<Game> games = new List<Game>();
            games.Add(this.getPastGame());
            games.Add(this.getPastGame());
            games.ForEach(g => g.PutInGameDay(this.dut));

            bool result = this.dut.Complete;

            Assert.True(result);
        }

        [Fact]
        public void TestComplete_WhenNonePlayed_ThenFalse()
        {
            List<Game> games = new List<Game>();
            games.Add(this.getFutureGame());
            games.Add(this.getFutureGame());
            games.ForEach(g => g.PutInGameDay(this.dut));

            bool result = this.dut.Complete;

            Assert.False(result);
        }

        [Fact]
        public void TestComplete_WhenMixedPlayed_ThenFalse()
        {
            List<Game> games = new List<Game>();
            games.Add(this.getFutureGame());
            games.Add(this.getPastGame());
            games.Add(this.getFutureGame());
            games.ForEach(g => g.PutInGameDay(this.dut));

            bool result = this.dut.Complete;

            Assert.False(result);
        }

        [Fact]
        public void TestComplete_WhenNoGames_ThenFalse()
        {
            List<Game> games = new List<Game>();
            games.ForEach(g => g.PutInGameDay(this.dut));

            bool result = this.dut.Complete;

            Assert.False(result);
        }
    }
}

using System;
using System.Collections.Generic;
using Xunit;

using Pick_em.Lib.Domain;
using Pick_em.Lib.Models;

namespace Pick_em.Lib.Domain.Test
{
    public class SeasonTest
    {
        private Guid uniqueGuid = Guid.NewGuid();
        private SeasonModel model { get; set; }
        private Season dut { get; set; }

        public SeasonTest()
        {
            this.model = new SeasonModel()
            { 
                Id = uniqueGuid
            };
            this.dut = new Season(this.model);
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

        private GameDay getGameDay()
        {
            GameDayModel gdModel = new GameDayModel();
            GameDay gd = new GameDay(gdModel);
            return gd;
        }

        private void addMultipleGameDays(int count=3)
        {
            GameDay gd;
            for (int i=0; i<count; i++)
            {
                gd = getGameDay();
                gd.PutInSeason(this.dut);
            }
        }

        [Fact]
        public void TestId_WhenCalled_GivesGuid()
        {
            Guid result = this.dut.GetId();
            Assert.True(result.Equals(uniqueGuid));
        }

        [Fact]
        public void TestAdvance_WhenNoGD_ThenFalse()
        {
            bool result = this.dut.Advance();

            Assert.False(result);
        }

        [Fact]
        public void TestAdvance_WhenNotStarted_ThenTrue()
        {
            GameDay gd = this.getGameDay();
            gd.PutInSeason(this.dut);

            bool result = this.dut.Advance();

            Assert.True(result);
        }

        [Fact]
        public void TestAdvance_WhenStarted_ThenAllTrue()
        {
            this.addMultipleGameDays(3);

            bool result = this.dut.Advance(); // Start season
            result &= this.dut.Advance(); // Next GameDay

            Assert.True(result);
        }

        [Fact]
        public void TestAdvance_WhenLastAdvance_ThenAllTrue()
        {
            this.addMultipleGameDays(2);

            bool result = this.dut.Advance(); // Start season
            result &= this.dut.Advance(); // Next GameDay
            result &= this.dut.Advance(); // Complete Season

            Assert.True(result);
        }

        [Fact]
        public void TestAdvance_WhenAllDone_ThenFalse()
        {
            this.addMultipleGameDays(2);

            this.dut.Advance(); // Start season
            this.dut.Advance(); // Next GameDay
            this.dut.Advance(); // Complete Season
            bool result = this.dut.Advance(); // Season already done

            Assert.False(result);
        }
    }
}

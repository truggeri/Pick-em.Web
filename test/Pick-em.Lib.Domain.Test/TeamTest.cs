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

        [Fact]
        public void TestId_WhenCalled_GivesGuid()
        {
            Guid result = this.dut.GetId();
            Assert.True(result.Equals(uniqueGuid));
        }

        [Fact]
        public void TestPrimaryColor_WhenSet_ThenReturned()
        {
            string expected = "#FF6600";
            string notExpected = "#000";
            this.dut.PrimaryColor = expected;
            this.dut.SecondaryColor = notExpected;
            string result = this.dut.PrimaryColor;
            Assert.Equal(result, expected);
        }

        [Fact]
        public void TestPrimaryColor_WhenNotSet_ThenEmpty()
        {
            string result = this.dut.PrimaryColor;
            Assert.True(String.IsNullOrEmpty(result));
        }

        [Fact]
        public void TestSecondaryColor_WhenSet_ThenReturned()
        {
            string expected = "#000";
            string notExpected = "#FF6600";
            this.dut.PrimaryColor = notExpected;
            this.dut.SecondaryColor = expected;
            string result = this.dut.SecondaryColor;
            Assert.Equal(result, expected);
        }

        [Fact]
        public void TestSecondaryColor_WhenNotSet_ThenEmpty()
        {
            string result = this.dut.SecondaryColor;
            Assert.True(String.IsNullOrEmpty(result));
        }
    }
}
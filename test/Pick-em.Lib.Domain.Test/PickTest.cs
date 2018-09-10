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
    }
}
using System;
using Xunit;

namespace Assessment_Challenge_NAL
{
    public class UnitTest1
    {
        [Fact]
        public void FailingTest()
        {
                Assert.Equal(1,2);
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4,4);
        }
        [Fact]
        public void FailingTestSnd(){

                Assert.Equal(2,4);

        }
        [Fact]
        public void PassingTestSnd(){

                Assert.Equal(12,12);

        }
    }
}

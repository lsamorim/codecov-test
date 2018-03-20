using MyCore;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var service = new Service();

            Assert.Equal(1, service.Call());
        }
    }
}

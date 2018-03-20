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

        [Fact]
        public void Test12()
        {
            var service = new Service();

            Assert.Equal(2, service.Call2());
        }

        [Fact]
        public void Test2()
        {
            var service = new Service2();

            Assert.Equal(2, service.Call());
        }
    }
}

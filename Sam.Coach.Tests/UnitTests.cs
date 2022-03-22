using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using System;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new [] {4,3,5,8,5,0,0,-3}, new [] {3,5,8})]
        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = null;

            // TODO: create the finder instance and get the actual result
            Console.WriteLine("Test");
            Assert.True(false);

            // actual.Should().Equal(expected);
        }
    }
}

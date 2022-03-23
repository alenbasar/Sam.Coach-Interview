using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 0, -3 }, new[] { 3, 5, 8 })]
        [InlineData(new[] { 4, 6, -3, 3, 7, 9 }, new[] { -3, 3, 7, 9 })]
        [InlineData(new[] { 9, 6, 4, 5, 2, 0 }, new[] { 4, 5 })]
        [InlineData(new[] { 9, 6, 3, 5, 2, 0 }, new[] { 3, 5 })]
        [InlineData(new[] { 4, 6, 1, 2, 3, 5 }, new[] { 1, 2, 3, 5 })]
        [InlineData(new[] { int.MinValue, 1, -2147483642, 2, 3, 4 }, new[] { -2147483642, 2, 3, 4 })]
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            var finder = new LongestRisingSequenceFinder();
            IEnumerable<int> actual = await finder.Find(data);
            actual.Should().Equal(expected);
        }
    }
}

using Xunit;
using static xUnit.Parallel.Example.Tests.Integration.Constants;


namespace xUnit.Parallel.Example.Tests.Integration
{
    public class TheoryTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public async void Test(int number)
        {
            var value = Delay + number;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }
    }
}

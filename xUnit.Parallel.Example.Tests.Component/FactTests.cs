using Xunit;
using static xUnit.Parallel.Example.Tests.Component.Constants;

namespace xUnit.Parallel.Example.Tests.Component
{
    public class FactTests
    {

        [Fact]
        public async void Test1()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test2()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test3()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test4()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test5()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test6()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test7()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test8()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test9()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public async void Test10()
        {
            var value = Delay;

            var result = await Program.LongRunningMethod(value);

            Assert.Equal(value, result);
        }
    }
}

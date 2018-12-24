using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NugetExampleProject;

namespace NugetExampleProjectTests
{
    [TestClass]
    public class ExampleTests
    {
        [TestMethod]
        public void IsGreaterThan_OneGreaterThanTwo_ShouldBeFalse()
        {
            int one = 1;
            int two = 2;

            var result = one.IsGreaterThan(two);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsGreaterThan_TwoGreaterThanOne_ShouldBeTrue()
        {
            int one = 1;
            int two = 2;

            var result = two.IsGreaterThan(one);

            result.Should().BeTrue();
        }
    }
}

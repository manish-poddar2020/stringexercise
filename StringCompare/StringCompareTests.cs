using FluentAssertions;
using Xunit;

namespace StringCompare
{
    public class StringCompareTests
    {
        [Fact]
        public void AreEqual_WithEmptyStrings_ReturnsTrue()
        {
            string first = "";
            string second = "";

            var result = StringCompare.AreEqual(first, second);

            result.Should().BeTrue();
        }

        [Fact]
        public void AreEqual_WithDifferentStrings_ReturnsFalse()
        {
            string first = "first";
            string second = "second";

            var result = StringCompare.AreEqual(first, second);

            result.Should().BeFalse();
        }
    }
}

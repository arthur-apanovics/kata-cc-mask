using FluentAssertions;
using KataCreditCardMask;

namespace KataCredirtCardMaskUnitTests;

public class UnitTest1
{
    [Theory]
    [InlineData("4556364607935616", "############5616")]
    [InlineData("64607935616", "#######5616")]
    [InlineData("1", "1")]
    [InlineData("", "")]
    [InlineData("Nananananananananananananananana Batman!", "####################################man!")]
    [InlineData("Skippy", "##ippy")]
    public void ShouldMaskString(string input, string expected)
    {
        var actual = StringMasker.Mask(input);

        actual.Should().Be(expected);
    }
}
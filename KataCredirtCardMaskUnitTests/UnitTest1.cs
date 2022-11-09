using FluentAssertions;
using KataCreditCardMask;

namespace KataCredirtCardMaskUnitTests;

public class UnitTest1
{
    // '4556364607935616' // should return "############5616"
    // '64607935616' // should return "#######5616"
    // '1' // should return "1"
    // '' // should return ""
    [Theory]
    [InlineData("4556364607935616", "############5616")]
    [InlineData("64607935616", "#######5616")]
    [InlineData("1", "1")]
    [InlineData("", "")]
    public void ShouldMaskString(string input, string expected)
    {
        var actual = StringMasker.Mask(input);

        actual.Should().Be(expected);
    }


    // "What was the name of your first pet?" 'Skippy' // should return "##ippy"
    // 'Nananananananananananananananana Batman!' // should return "####################################man!"
}
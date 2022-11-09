using FluentAssertions;

namespace KataCredirtCardMaskUnitTests;

public class UnitTest1
{
    // '4556364607935616' // should return "############5616"
    // '64607935616' // should return "#######5616"
    // '1' // should return "1"
    // '' // should return ""
    [Fact]
    public void ShouldMaskString()
    {
        var expected = "############5616";
        var sut = "4556364607935616";

        var actual = DoTheThing(sut);

        actual.Should().Be(expected);
    }

    private string DoTheThing(string input)
    {
        var end = input.TakeLast(4).ToString();
        var total = input.Length - 4;
        var output = new String('#', total);
        output += end;
        return output;
    }

    // "What was the name of your first pet?" 'Skippy' // should return "##ippy"
    // 'Nananananananananananananananana Batman!' // should return "####################################man!"

}
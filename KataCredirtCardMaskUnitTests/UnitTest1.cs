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

    // "What was the name of your first pet?" 'Skippy' // should return "##ippy"
    // 'Nananananananananananananananana Batman!' // should return "####################################man!"

}
using FluentAssertions;

namespace DisemvowelTrollsUnitTests;

public class UnitTest1
{
    // "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

    [Fact]
    public void Test1()
    {
        var input = "This website is for losers LOL!";
        var expected = "Ths wbst s fr lsrs LL!";

        var actual = VowelOperations.Remove(input);

        actual.Should().Be(expected);
    }
}
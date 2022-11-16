namespace DisemvowelTrollsUnitTests;

public class VowelOperations
{
    private static readonly string[] vowels = { "a", "e", "i", "o", "u" };
    public static string Remove(string input)
    {
        var result = input;

        foreach (var vowel in vowels)
        {
            result = result.Replace(vowel, string.Empty, StringComparison.InvariantCultureIgnoreCase);
        }

        return result;
    }
}
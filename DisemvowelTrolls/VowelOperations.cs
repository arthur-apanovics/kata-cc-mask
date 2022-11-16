namespace DisemvowelTrollsUnitTests;

public class VowelOperations
{
    private static readonly char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
    public static string Remove(string input)
    {
        string result;
        foreach (var vowel in vowels)
        {
            result = input.Replace(vowel, string.Empty);
        }
    }
}
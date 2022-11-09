namespace KataCreditCardMask;

public class StringMasker
{
    private const int UnmaskedCharLength = 4;

    public static string Mask(string input)
    {
        return GetMaskedSection(input) + GetUnmaskedSection(input);
    }

    private static string GetMaskedSection(string input)
    {
        var maskedLength = input.Length - UnmaskedCharLength;
        if (maskedLength < 0)
            maskedLength = 0;

        var maskedSection = new string('#', maskedLength);
        return maskedSection;
    }

    private static string GetUnmaskedSection(string input)
    {
        return new string(input.TakeLast(UnmaskedCharLength).ToArray());
    }
}
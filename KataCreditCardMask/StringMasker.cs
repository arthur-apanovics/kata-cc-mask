namespace KataCreditCardMask;

public class StringMasker
{
    private const int UnmaskedCharLength = 4;
    private const char MaskingChar = '#';

    public static string Mask(string input)
    {
        return GetMaskedSection(input) + GetUnmaskedSection(input);
    }

    private static string GetMaskedSection(string input)
    {
        var maskedLength = GetMaskedLength(input);
        
        if (maskedLength < 0)
        {
            return string.Empty;
        }

        var maskedSection = new string(MaskingChar, maskedLength);
        
        return maskedSection;
    }

    private static int GetMaskedLength(string input)
    {
        return input.Length - UnmaskedCharLength;
    }

    private static string GetUnmaskedSection(string input)
    {
        return new string(input.TakeLast(UnmaskedCharLength).ToArray());
    }
}
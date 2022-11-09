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
        maskedLength = EnsureMaskedLengthIsNotNegative(maskedLength);
        var maskedSection = CreateMaskedSection(maskedLength);
        
        return maskedSection;
    }

    private static string CreateMaskedSection(int maskedLength)
    {
        var maskedSection = new string(MaskingChar, maskedLength);
        return maskedSection;
    }

    private static int EnsureMaskedLengthIsNotNegative(int maskedLength)
    {
        if (maskedLength < 0)
        {
            maskedLength = 0;
        }

        return maskedLength;
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
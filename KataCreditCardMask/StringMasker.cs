namespace KataCreditCardMask;

public class StringMasker
{
    private static readonly int _unmaskedCharLength = 4;

    public static string Mask(string input)
    {
        var end = input.TakeLast(_unmaskedCharLength).ToArray();
        var endString = new string(end);
        var total = input.Length - _unmaskedCharLength;
        var output = new string('#', total);
        output += endString;

        return output;
    }

}
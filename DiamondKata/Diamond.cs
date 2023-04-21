using System.Text;

namespace DiamondKata;

public static class Diamond
{
    public static string Generate(char targetLetter)
    {
        if (!char.IsAsciiLetter(targetLetter))
        {
            throw new ArgumentException($"Target letter {targetLetter} is not a valid ASCII letter", nameof(targetLetter));
        }
        
        return GenerateOutput(char.ToUpper(targetLetter));
    }

    private static string GenerateOutput(char targetLetter)
    {
        var outputBuilder = new StringBuilder();
        
        for (var i = 'A'; i < targetLetter; i++)
        {
            outputBuilder.AppendLine(GenerateRow(i, targetLetter));
        }

        for (var i = targetLetter; i >= 'A'; i--)
        {
            outputBuilder.AppendLine(GenerateRow(i, targetLetter));
        }

        return outputBuilder.ToString();
    }

    private static string GenerateRow(char currentChar, char maxChar)
    {
        var outsidePadding = maxChar - currentChar;
        var insidePadding = (currentChar - 'A') * 2 - 1;

        var builder = new StringBuilder();
        builder.Append(new string('-', outsidePadding));
        builder.Append(currentChar);
        if (insidePadding > 0)
        {
            builder.Append(new string('-', insidePadding));
            builder.Append(currentChar);
        }

        builder.Append(new string('-', outsidePadding));
        return builder.ToString();
    }
}
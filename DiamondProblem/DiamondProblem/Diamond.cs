using System.Text;
using System.Text.RegularExpressions;

namespace DiamondProblem;

public abstract class Diamond
{
    public static char HandleInput()
    {
        Console.WriteLine("Enter a character between [a-z]:");
        string? input = Console.ReadLine()?.ToUpper();

        if (!ValidateInput(input, out var errorMsg))
        {
            Console.WriteLine(errorMsg);
        }
        return Convert.ToChar(input);
    }

    private static bool ValidateInput(string? input, out string errorMsg)
    {
        errorMsg = string.Empty;
        if (input is null)
        {
            errorMsg = "Invalid input, ensure a value is entered";
            return false;
        } 
        Regex regex = new Regex("^[A-Z]$");
        if(!regex.IsMatch(input))
        {
            errorMsg = "Invalid input, please provide a character between A and Z ";
            return false;
        }
        return true;
    }

    public static string GenerateDiamond(char input)
    {
        var rows = new StringBuilder(); 
        
        //Generate the top half and the middle line of the diamond
        for (char character = 'A'; character <= input; character++)
        {
            rows.Append(CreateLine(input, character));
        }
        
        // Generate the bottom half of the diamond
        for (char character = (char)(input - 1); character >= 'A'; character--)
        {
            rows.Append(CreateLine(input, character));
        }
        
        return rows.ToString(); 
    }

    private static string CreateLine(char input, char character)
    {
        var row = new StringBuilder();

        // Leading spaces
        row.Append(new string(' ', input - character));

        // The character
        row.Append(character);

        if (character != 'A')
        {
            row.Append(new string(' ', (character - 'A') * 2 - 1));
            row.Append(character);
        }
        row.Append('\n');
        return row.ToString();
    }
}
using System.Text;

namespace DiamondProblem;

public class Diamond
{
    public static string HanldeInput()
    {
        Console.WriteLine("Enter a character between [a-z]");
        var input = Console.ReadLine()?.ToUpper();
        
        //TODO Validation 
        return input; 
    }
    public static string GenerateDiamond(char input)
    {
        StringBuilder rows = new StringBuilder(); 
        
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
        StringBuilder row = new StringBuilder();

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
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
        
        //Short circuit for A
        if (input == 'A') return "A"; 
        
        //TopHalf of diamond
        int indentationCount = 0;
        int middleCharacterPosition = input - 'A';
        for (char character = 'A'; character <= input; character++)
        {
            StringBuilder row = new StringBuilder();
            if (character == 'A')
            {
                row.Append(new string(' ', middleCharacterPosition));
                row.Append(character); 
            }
            else
            {
                //Leading spaces
                row.Append(new string(' ', input - character));
                row.Append(character);
                
                //Spaces after
                row.Append(new string(' ', 2 * indentationCount -1));
                row.Append(character);
            }

            Console.WriteLine(row);
            row.Append('\n'); 
            rows.Append(row); 
            indentationCount++; 
        }
        return rows.ToString(); 
    }
}
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
        List<string> rows = new(); 
        
        //Short circuit for A
        if (input == 'A') return "A"; 
        

        return string.Empty; 
    }
}
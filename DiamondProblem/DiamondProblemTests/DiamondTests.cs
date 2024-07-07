using DiamondProblem;

namespace DiamondProblemTests;

public class DiamondTests
{
    [Fact]
    public void GenerateDiamond_InputA_ReturnsDepthOfOne()
    {
        Assert.Equal("A",Diamond.GenerateDiamond('A'));
    }
    [Fact (Skip = "Iterated beyond")]
    public void GenerateDiamond_InputC_ReturnsCorrectNumberOfCharactersWithNoIndentation()
    {
        Assert.Equal("ABC",Diamond.GenerateDiamond('C'));
    }
    [Fact (Skip = "Iterated beyond")]
    public void GenerateDiamond_InputC_ReturnsCharactersOnNewLines()
    {
        Assert.Equal("A\nB\nC\n",Diamond.GenerateDiamond('C'));
    }
    [Fact]
    public void GenerateDiamond_InputC_ReturnsTopDepthWithCorrectSpacingBeforeAndAfter()
    {
        Assert.Equal("  A\n B B\nC   C\n",Diamond.GenerateDiamond('C'));
    }
    [Theory]
    [InlineData('C', "  A\n B B\nC   C\n B B\n  A\n")]
    public void GenerateDiamond_ValidInput_ReturnsCorrectDepthWithSpacingBeforeAndAfter(char inputCharacter, string expectedOutput)
    {
        Assert.Equal(expectedOutput,Diamond.GenerateDiamond(inputCharacter));
    }
}
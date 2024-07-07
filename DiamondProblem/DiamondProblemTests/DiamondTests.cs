using DiamondProblem;

namespace DiamondProblemTests;

public class DiamondTests
{
    [Fact]
    public void GenerateDiamond_InputA_ReturnsDepthOfOne()
    {
        Assert.Equal("A",Diamond.GenerateDiamond('A'));
    }
    [Fact]
    public void GenerateDiamond_InputC_ReturnsCorrectNumberOfCharactersWithNoIndentation()
    {
        Assert.Equal("ABC",Diamond.GenerateDiamond('C'));
    }
    [Fact]
    public void GenerateDiamond_InputC_ReturnsCharactersOnNewLines()
    {
        Assert.Equal("A\nB\nC\n",Diamond.GenerateDiamond('C'));
    }
}
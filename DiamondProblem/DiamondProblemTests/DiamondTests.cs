using DiamondProblem;

namespace DiamondProblemTests;

public class DiamondTests
{
    [Fact]
    public void GenerateDiamond_InputA_ReturnsDepthOfOne()
    {
        Assert.Equal("A\n",Diamond.GenerateDiamond('A'));
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
    [Fact (Skip = "Iterated beyond")]
    public void GenerateDiamond_InputC_ReturnsTopDepthWithCorrectSpacingBeforeAndAfter()
    {
        Assert.Equal("  A\n B B\nC   C\n",Diamond.GenerateDiamond('C'));
    }
    [Theory]
    [InlineData('C', "  A\n B B\nC   C\n B B\n  A\n")]
    [InlineData('E', "    A\n   B B\n  C   C\n D     D\nE       E\n D     D\n  C   C\n   B B\n    A\n")]
    [InlineData('G', "      A\n     B B\n    C   C\n   D     D\n  E       E\n F         F\nG           G\n F         F\n  E       E\n   D     D\n    C   C\n     B B\n      A\n")]
    [InlineData('Z', "                         A\n                        B B\n                       C   C\n                      D     D\n                     E       E\n                    F         F\n                   G           G\n                  H             H\n                 I               I\n                J                 J\n               K                   K\n              L                     L\n             M                       M\n            N                         N\n           O                           O\n          P                             P\n         Q                               Q\n        R                                 R\n       S                                   S\n      T                                     T\n     U                                       U\n    V                                         V\n   W                                           W\n  X                                             X\n Y                                               Y\nZ                                                 Z\n Y                                               Y\n  X                                             X\n   W                                           W\n    V                                         V\n     U                                       U\n      T                                     T\n       S                                   S\n        R                                 R\n         Q                               Q\n          P                             P\n           O                           O\n            N                         N\n             M                       M\n              L                     L\n               K                   K\n                J                 J\n                 I               I\n                  H             H\n                   G           G\n                    F         F\n                     E       E\n                      D     D\n                       C   C\n                        B B\n                         A\n")]
    public void GenerateDiamond_ValidInput_ReturnsCorrectDepthWithSpacingBeforeAndAfter(char inputCharacter, string expectedOutput)
    {
        Assert.Equal(expectedOutput,Diamond.GenerateDiamond(inputCharacter));
    }
}
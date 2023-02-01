namespace MarsRoverKata.Tests;

public class MarsRoverKataTests
{
    private readonly MarsRover _marsRover;

    public MarsRoverKataTests()
    {
        _marsRover = new MarsRover(new Grid(5,5));
    }

    [Fact]
    public void CheckStartingPosition()
    {
        Assert.Equal("0:0:N", _marsRover.Execute(""));
    }

    [Theory]
    [InlineData("M", "0:1:N")]
    [InlineData("MMM", "0:3:N")]
    [InlineData("MMMMMM", "0:1:N")]
    public void ExecuteMoveCommands(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.Execute(command));
    }

    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRRR", "0:0:E")]
    public void ExecuteRightRotationCommands(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.Execute(command));
    }
    
    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLLL", "0:0:W")]
    public void ExecuteLeftRotationCommands(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.Execute(command));
    }
    
    [Theory]
    [InlineData("MLLM", "0:0:S")]
    [InlineData("MLLMM", "0:4:S")]
    [InlineData("MLLMMMMMM", "0:0:S")]
    public void ExecuteMixedCommands(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.Execute(command));
    }
    
    
}
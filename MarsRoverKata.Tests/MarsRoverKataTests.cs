namespace MarsRoverKata.Tests;

public class MarsRoverKataTests
{
    [Fact]
    public void CheckStartingPosition()
    {
        var marsRover = new MarsRover();
        Assert.Equal("0:0:N", marsRover.Execute(""));
    }
    
    [Fact]
    public void ExecuteMoveCommand()
    {
        var marsRover = new MarsRover();
        Assert.Equal("0:1:N", marsRover.Execute("M"));
    }

    [Fact]
    public void ExecuteMultipleMoveCommands()
    {
        var marsRover = new MarsRover();
        Assert.Equal("0:3:N", marsRover.Execute("MMM"));
    }
}
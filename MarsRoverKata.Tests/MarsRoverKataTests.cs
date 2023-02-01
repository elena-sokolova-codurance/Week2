namespace MarsRoverKata.Tests;

public class MarsRoverKataTests
{
    [Fact]
    public void CheckGridSize()
    {
        var marsRover = new MarsRover(new Grid(5,5));
        Assert.Equal("5x5", marsRover.GetGridSize());
    }

    [Fact]
    public void CheckStartingPosition()
    {
        var marsRover = new MarsRover(new Grid(5,5));
        Assert.Equal("0:0:N", marsRover.Execute(""));
    }
    
    [Fact]
    public void ExecuteMoveCommand()
    {
        var marsRover = new MarsRover(new Grid(5,5));
        Assert.Equal("0:1:N", marsRover.Execute("M"));
    }
}
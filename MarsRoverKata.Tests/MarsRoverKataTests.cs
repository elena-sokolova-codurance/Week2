namespace MarsRoverKata.Tests;

public class MarsRoverKataTests
{
    [Fact]
    public void CheckGridSize()
    {
        int height = 5;
        int width = 5;
        Grid grid = new Grid(height,width);
        MarsRover marsRover = new MarsRover(grid);

        Assert.Equal(marsRover.GetGridSize(), height * width);

    }
}
namespace MarsRoverKata;

public class MarsRover
{
    private readonly Grid _grid;
    public MarsRover(Grid grid)
    {
        this._grid = grid;
    }

    public int GetGridSize()
    {
        var gridSize = _grid.Height * _grid.Width;
        return gridSize;
    }
}
namespace MarsRoverKata;

public class Position
{
    internal int X = 0;
    internal int Y = 0;

    private readonly Grid _grid;

    public Position(Grid grid)
    {
        _grid = grid;
    }
    public void MoveUp()
    {
        Y = (Y + 1) % _grid.Height;
    }

    public void MoveDown()
    {
        Y = (_grid.Height + Y - 1) % _grid.Height;
        
    }
}
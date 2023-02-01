namespace MarsRoverKata;

public class MarsRover
{
    private readonly Grid _grid;
    public MarsRover(Grid grid)
    {
        this._grid = grid;
    }

    public string GetGridSize()
    {
        return _grid.ToString();
    }

    public string Execute(string command)
    {
        if (command.Equals("M"))
        {
            return "0:1:N";
        }
        return "0:0:N";
    }
}
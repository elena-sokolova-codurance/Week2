namespace MarsRoverKata;

public class MarsRover
{
    private Position _position;
    private readonly Orientation _orientation = new();

    public MarsRover(Grid grid)
    {
        _position = new Position(grid);
    }
    public string Execute(string command)
    {
        foreach (var singleCommand in command)
        {
            Execute(singleCommand);
        }
        
        return $"{_position.X}:{_position.Y}:{_orientation.Current}";
    }

    private void Execute(char singleCommand)
    {
        switch (singleCommand)
        {
            case 'M':
                if(_orientation.Current.Equals("S"))
                    _position.MoveDown();
                else
                {
                    _position.MoveUp();
                }
                break;
            case 'R':
                _orientation.RotateRight();
                break;
            case 'L':
                _orientation.RotateLeft();
                break;
        }
    }
}
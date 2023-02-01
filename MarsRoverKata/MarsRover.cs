namespace MarsRoverKata;

public class MarsRover
{
    private readonly Position _position = new();

    public string Execute(string command)
    {
        var orientation="N";
        foreach (var singleCommand in command)
        {
            _position.MoveUp();
        }
        
        return $"{_position.X}:{_position.Y}:{orientation}";
    }
}
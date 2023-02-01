namespace MarsRoverKata;

class Orientation
{
    private const string North = "N";
    private const string East = "E";
    private const string South = "S";
    private const string West = "W";

    internal string Current = North;   

    public void RotateRight()
    {
        Current = Current switch
        {
            North => East,
            East => South,
            South => West,
            West => North,
            _ => Current
        };
    }

    public void RotateLeft()
    {
        Current = Current switch
        {
            North => West,
            West => South,
            South => East,
            East => North,
            _ => Current
        };
    }
}
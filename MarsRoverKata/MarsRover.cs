namespace MarsRoverKata;

public class MarsRover
{
    private readonly Position _position = new();
    private readonly Orientation _orientation = new();

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
    }

    public string Execute(string command)
    {
        foreach (var singleCommand in command)
        {
            if (singleCommand.Equals('M'))
            {
                _position.MoveUp();
            } 
            if (singleCommand.Equals('R'))
            {
                _orientation.RotateRight();
            }

        }
        
        return $"{_position.X}:{_position.Y}:{_orientation.Current}";
    }
}
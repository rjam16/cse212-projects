/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        //check right
        if (_mazeMap.TryGetValue((_currX, _currY), out bool [] directions)) // does current position exist?
            {
                if (directions[0]) //left is first
                    {
                        _currX--;//x is left and right +x is right -x is left
                    }
                else
                {
                    throw new InvalidOperationException("Can't go that way!");
                }
            }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
        if (_mazeMap.TryGetValue((_currX, _currY), out bool [] directions)) //does position exist
            {
                if (directions[1]) //right is second
                    {
                        _currX++;//x is left and right +x is right -x is left
                    }
                else
                {
                    throw new InvalidOperationException("Can't go that way!");
                }
            }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        if (_mazeMap.TryGetValue((_currX, _currY), out bool [] directions))
            {
                if (directions[2]) //Up is third
                    {
                        _currY--;//y is up and down +y is down -y is up
                    }
                else
                {
                    throw new InvalidOperationException("Can't go that way!");
                }
            }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        if (_mazeMap.TryGetValue((_currX, _currY), out bool [] directions))
            {
                if (directions[3]) //down is last
                    {
                        _currY++;//y is up and down +y is down -y is up
                    }
                else
                {
                    throw new InvalidOperationException("Can't go that way!");
                }
            }

    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}
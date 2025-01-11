using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        var multi_array = new double [length];
        // set up fixed array that results can be put into
        for (int i = 0; i < length; ++i) {
        // set up loop for each index in the array
            multi_array[i] = number * (i + 1);
        //multiply the number given incrementally to return multiples, assign value to given index of the array
        }
        return multi_array; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        var moved_left = data.GetRange(data.Count - amount, amount);
        //get list of data from the end of data to the point of the shift
        data.RemoveRange(data.Count - amount, amount);
        //remove retrieved range from data(it is currently stored as moved_left)
        //results.AddRange(moved_left);
        //add previously made data into the resulting array
        //var moved_right = data.GetRange(0, data.Count - amount);
        data.InsertRange(0, moved_left);
        //gather remaining data from data array
        //results.AddRange(moved_right);
        //add remaining data to resulting array
        return;



        }

    }

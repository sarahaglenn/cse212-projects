using System.Diagnostics;
using System.Globalization;
using System.Runtime;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

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
        // Create an empty array with length = length given
        double[] result = new double[length];
        // Add the given number to the first position of the array
        result[0] = number;
        // Use a for loop with an index equal to one, as long as the index is 
        // less than the length given -->
        for (int i = 1; i < length; i++) {
            // Add the number multiplied by (the current index + 1) to the current index
            // position of the array
            result[i] = number * (i + 1);
        }
        // Outside of the loop, return the array created
        return result;
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
        // Split the array into two separate lists
        // Starting at index zero and collecting (count - amount) elements will be the 
        // ending of the new array
        List<int> ending = data.GetRange(0, data.Count - amount);
        // The items from index = (count - amount) to the end of the array will be the first
        // part of the new array. (the number of elements is equal to the size of the shift)
        List<int> starting = data.GetRange(data.Count - amount, amount);
        // Clear the elements from the original list
        data.Clear();
        // Combine the two lists in the correct order
        foreach (int num in starting) {
            data.Add(num);
        }
        foreach (int num in ending) {
            data.Add(num);
        }
    }
}

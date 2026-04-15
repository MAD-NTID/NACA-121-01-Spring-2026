using System.ComponentModel.DataAnnotations;

public class MergeSort<T>
{
    public T[] Sort(T[] elements)
    {
        // This is the final sorted array
        T[] sorted = []; 

        // Base Case - if the size of elements is 1, then return T[] elements
        if(elements.Length == 1)
            return elements;

        // Find the midpoint of T[] elements
        int midpoint = elements.Length / 2;

        // Create the left and the right portion of the divided array
        T[] left = Copy(elements, 0, midpoint);
        T[] right = Copy(elements, midpoint, elements.Length);

        // Do recursion to themselves (this keeps the order intact)
        left = Sort(left);

        // These come only after left recursion is completed
        right = Sort(right);

        // Here we merge
        return Merge(left, right);
    }

    public T[] Merge(T[] arrayA, T[] arrayB)
    {
        // Create a new array with the size of both arrays a and b
        T[] merged = new T[arrayA.Length + arrayB.Length];

        // These are our index controllers for the arrays
        int indexA = 0, indexB = 0, indexSorted = 0; 

        // We need a comparer to compare values from smallest to largest
        Comparer<T> comparer = Comparer<T>.Default;
        
        // The actual "Merge" happens here
        // We need to assess all values in both arrays
        while(indexA < arrayA.Length && indexB < arrayB.Length)
        {
            if(comparer.Compare(arrayA[indexA], arrayB[indexB]) <= 0)
            {
                // Insert into the indexSorted position and increment by 1
                // Since we assessed indexA, we also increment by 1
                merged[indexSorted ++] = arrayA[indexA ++];
            }
            else
            {
                // This happens when right side is greater or equal to the left
                // Insert into the indexSorted position and increment by 1
                // Since we assessed indexA, we also increment by 1
                merged[indexSorted ++] = arrayB[indexB ++];
            }
        }

        // Copy the remaining elements from the individual arrays
        // For values that were not assessed during the merge
        while(indexA < arrayA.Length)
        {
            merged[indexSorted ++] = arrayA[indexA ++];
        }

        while(indexB < arrayB.Length)
        {
            merged[indexSorted ++ ] = arrayB[indexB ++];
        }

        return merged;
    }

    /*
        T[] elements is the array to be split
        int startLength is the start index
        int endLength is the stop index
    */
    public T[] Copy(T[] elements, int startLength, int endLength)
    {
        // Create a temporary array, with the length endLEngth - startLength
        T[] copy = new T[endLength - startLength];

        int index = 0;

        // Use the startLength and endLengthto control the loop counter
        // But, use a separate indexer starting with 0 because all new arrays
        // Always will start at index 0
        for(int i = startLength; i < endLength; i++)
            copy[index ++] = elements[i];

        return copy;
    }
}
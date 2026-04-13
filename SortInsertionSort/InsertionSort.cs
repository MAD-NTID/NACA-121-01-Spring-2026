public class InsertionSort<T>
{
    private T[] original;
    private T[] sorted;
    public T[] MyProperty
    {
        get { return sorted; }
    }    

    public InsertionSort(T[] unsorted)
    {
        original = unsorted;
        sorted = unsorted;
    }

    /*
        Sorts the array in ascending order using insertion sort
        In-Place: Changes the original array
    */
    public T[] Sort()
    {
        // Make a copy of the original
        // We will still do In-Place sorting in the copied 'unsorted' array
        T[] unsorted = original;

        // We use this comparer for comparing left and right elements
        Comparer<T> comparer = Comparer<T>.Default;

        for(int i = 1; i < original.Length; i++)
        {
            T currentElement = original[i];

            // j will track the position in the sorted portion (left side)
            // We start by looking at the element just before 1
            int j = i - 1;

            /*
                Move backwards through the sorted portion
                Shift elements to the right if they are greater than "current"
            */
            while(j >= 0 && comparer.Compare(original[j], currentElement) > 0)
            {
                // Move larger element one position to the right
                original[j + 1] = original[j];

                // Move left to check the next element
                j--;
            }

            /*
                At this point, we found the correct position for "currentElement"
                Insert it into its sorted spot
            */
            original[j + 1] = currentElement;
        }

        // Update the sorted array
        return sorted = original;
    }
}
public class Quicksort<T>
{
   public void Sort(T[] values, int low, int hi)
    {
        //base case, prevent invalid range
        if(low>=hi || low < 0)
            return ; //do nothing
        
        int pivotIndex = Partition(values, low, hi);

        //recursively do the left subarray
        Sort(values, low, pivotIndex-1);

        //recursively do the right
        Sort(values, pivotIndex+1, hi);
    } 

    private int Partition(T[] values, int low, int hi)
    {
        //pick the last as the pivot
        T pivot = values[hi];

        //tracks the boundary of elements less than or equals to pivot
        int i = low-1;

        // We need a comparer to compare values from smallest to largest
        Comparer<T> comparer = Comparer<T>.Default;

        for(int j = low; j < hi; j++)
        {

            if(comparer.Compare(values[j], pivot) <= 0)
            {
                i++;
                Swap(values, i,j);
            }
        }
        //move the pivot to the correct sorted position
        i++;
        Swap(values, i, hi);

        return i;
    }

    public void Swap(T[] values, int i, int j)
    {
        //temp hold the value at position 0
        T temp = values[i];

        values[i] = values[j];
        values[j] = temp;
    }
}
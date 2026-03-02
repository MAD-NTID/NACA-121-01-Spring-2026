// <T> is a place holder to pass a type
public class Printer<T>
{
    private T[] jobs;

    // To keep track of jobs printed, and job positions (indexes)
    private int jobPositionPrinted, jobPositions;
    
    public int Size 
    { 
        get
        {
            return jobs.Length;     
        }
    }

    public Printer(int numberOfJobs = 10)
    {
        jobs = new T[numberOfJobs];
    }

    public bool Add(T value)
    {
        // Ensure size is not greater than available array length
        if(jobPositions == jobs.Length)
            return false;

        // Add the job to the jobs array and increment by one
        jobs[jobPositions++] = value;

        return true;
    }

    public T Print()
    {
        // if jobsPrinted is 0, that means all the jobs have been printed
        // then, we can start adding new jobs again
        if(jobPositions == jobPositionPrinted)
        {
            // reset
            jobPositions = 0;
            jobPositionPrinted = 0;
        }

        // Recall, T is whatever you declared the object as (type)
        T document = jobs[jobPositionPrinted++];

        // What justifies the type that is returned?
        return document;
    }

    public bool Cancel(T job)
    {
        // Search for the value of the job to remove from the array
        for(int i = 0; i < jobs.Length; i++)
        {
            if(EqualityComparer<T>.Default.Equals(jobs[i], job))
            {
                jobs[i] = default;
                return true;
            }
        }

        return false;
    }

    public override string ToString()
    {
        return $"{jobs.GetType()}";
    }
}
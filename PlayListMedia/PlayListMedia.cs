public abstract class PlayListMedia<T> : IPlayListMedia<T>
{
    protected int totalMedia;

    public PlayListMedia()
    {
        totalMedia = 0;
    }

    // We declare these methods as abstract
    // And let the implementing class decide what behaviors they need for it
    // This makes it a requirement but provides flexibility on implementation
    public abstract void Add(T media);

    public abstract T Play();

    public abstract T ShowNextMedia();

    public int GetTotalMedia()
    {
        return totalMedia;
    }
}
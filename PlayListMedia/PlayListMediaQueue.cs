public class PlayListMediaQueue<T> : PlayListMedia<T>
{
    private Queue<T> playlist;

    public PlayListMediaQueue()
    {
        playlist = new Queue<T>();
    }

    public override void Add(T media)
    {
        playlist.Enqueue(media);
        totalMedia ++;
    }

    public override T Play()
    {
        T media = playlist.Dequeue();
        totalMedia --;

        return media;
    }

    public override T ShowNextMedia()
    {
        return playlist.Peek();
    }
}
public interface IPlayListMedia<T>
{
    

    public void Add(T media);
    public T ShowNextMedia();
    public T Play();
    public int GetTotalMedia();
}
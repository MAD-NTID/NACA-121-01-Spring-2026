public class Video
{
    public string Title { get; }
    public string Duration { get; }
    public string Category { get; }

    public Video(string title, string duration, string category)
    {
        Title = title;
        Duration = duration;
        Category = category;
    }

    // Not required for this exam - just for show
    // public Video(string[] movieInfo)
    // {
    //     Title = movieInfo[0];
    //     Duration = movieInfo[1];
    //     Category = movieInfo[2];
    // }

    public override string ToString()
    {
        return $"{Title}, {Duration}, {Category}";
    }
}
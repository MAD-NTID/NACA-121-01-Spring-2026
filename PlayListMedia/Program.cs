/*
Write code to create a playListMediaStack object 
with IPlayListMedia as the type for Videos. Do the 
same for creating a playListMediaQueue object.
*/
IPlayListMedia<Video> stack = new PlayListMediaStack<Video>();
IPlayListMedia<Video> queue = new PlayListMediaQueue<Video>();

const string MOVIES_FILE_PATH = "./movies.csv";
const string STACK_FILE_OUTPUT = "./stack_results.csv";
const string QUEUE_FILE_OUTPUT = "./queue_results.csv";

// Load movies.txt - validate file exists
if(File.Exists(MOVIES_FILE_PATH))
{
    // StreamReader sr = new StreamReader(MOVIES_FILE_PATH);
    StreamReader sr = new(MOVIES_FILE_PATH);
    bool skipHeaders = false;

    while(!sr.EndOfStream)
    {
        if(!skipHeaders)
        {
            // Read, so that the streamreader pointer moves to the next line
            sr.ReadLine();
            skipHeaders = true;
            continue;
        }

        // Movie info extracted to an array
        string[] movieString = sr.ReadLine().Split(",");
        // movieString[0] title
        // movieString[1] duration
        // movieString[2] category
        Video video = new(movieString[0], movieString[1], movieString[2]);
        // Video video = new(movieString);

        queue.Add(video);
        Console.WriteLine($"Added {video} to the queue");

        stack.Add(video);
        Console.WriteLine($"Added {video} to the stack");

        Console.WriteLine();
    }

    sr.Close();
    Console.WriteLine($"All ({queue.GetTotalMedia()}) video(s) are loaded in the stack and queue playlists\n");
    // Good time for testing

    /*
    Iterate the stack playlist and save the output by invoking the ShowNextMedia(), and Play() methods for
    each video object, write to “stack_results.txt”.
    */
    StreamWriter stackWriter = new(STACK_FILE_OUTPUT);
    stackWriter.WriteLine("Stack\n============================");

    int totalMediaStack = stack.GetTotalMedia();
    for(int i = 0; i < totalMediaStack; i++)
    {
        stackWriter.WriteLine($"Next: {stack.ShowNextMedia()}");
        stackWriter.WriteLine($"Play: {stack.Play()}");
    }

    stackWriter.Close();

    StreamWriter queueWriter = new(QUEUE_FILE_OUTPUT);
    queueWriter.WriteLine("Queue\n============================");

    int totalMediaQueue = queue.GetTotalMedia();
    for(int i = 0; i < totalMediaQueue; i++)
    {
        queueWriter.WriteLine($"Next: {queue.ShowNextMedia()}");
        queueWriter.WriteLine($"Play: {queue.Play()}");
    }

    queueWriter.Close();

    Console.WriteLine("Finished Peeking and Playing all video titles");
}
else
{
    Console.WriteLine($"Cluld not locate file path {MOVIES_FILE_PATH}");
}
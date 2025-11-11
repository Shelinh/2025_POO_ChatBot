public class VideoMessage : MediaMessage
{
    VideoMessage(string message): base(message) { }
    public int Duration {get; set;}

}

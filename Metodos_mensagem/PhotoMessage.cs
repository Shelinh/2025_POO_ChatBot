public class MidiaMessage : MessageBase
{

  public string File {get; set;}
  public string Format {get; set;}

    MediaMessage(string message): base(message) { }
}

public class VideoMessage : MediaMessage
{
    VideoMessage(string message): base(message) { }
    public int Duration {get; set;}

}

public class PhotoMessage : MediaMessage
{
    public PhotoMessage(string message): base(message) { }

}

public class FileMessage : MediaMessage
{
    public FileMessage(string message): base(message) { }
}
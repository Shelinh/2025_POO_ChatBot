public class MidiaMessage : MessageBase
{

  public string File {get; set;}
  public string Format {get; set;}

    MediaMessage(string message): base(message) { }
}
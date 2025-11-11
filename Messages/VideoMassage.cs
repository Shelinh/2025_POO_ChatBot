using System;
namespace ChatBotApp.Messages
{
    public class VideoMessage : MediaMessage
    {
        public int Duration { get; set; }

        public VideoMessage(string message) : base(message) { }
    }
}

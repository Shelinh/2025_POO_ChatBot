namespace ChatBotApp.Messages
{
    public abstract class MediaMessage : MessageBase
    {
        public string File { get; set; }
        public string Format { get; set; }

        protected MediaMessage(string message) : base(message) { }
    }
}

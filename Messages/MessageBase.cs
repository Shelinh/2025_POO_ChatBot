using System;

namespace ChatBotApp.Messages
{
    public abstract class MessageBase
    {
        public string Message { get; }
        public DateTime SendAt { get; }

        protected MessageBase(string message)
        {
            Message = message;
            SendAt = DateTime.Now;
        }
    }
}

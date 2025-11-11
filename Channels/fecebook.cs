using System;
using ChatBotApp.Channels;

namespace ChatBotApp.Channels
{
    public class Facebook
    {
        public void EnviarMensagem(string usuario, TextMessage message)
        {
            Console.WriteLine($"[Facebook] Enviando texto para {usuario}: {message.Message}");
        }

        public void EnviarMensagem(string usuario, PhotoMessage message)
        {
            Console.WriteLine($"[Facebook] Enviando foto '{message.File}' ({message.Format}) para {usuario}");
        }

        public void EnviarMensagem(string usuario, VideoMessage message)
        {
            Console.WriteLine($"[Facebook] Enviando vídeo '{message.File}' ({message.Format}) duração {message.Duration}s para {usuario}");
        }

        public void EnviarMensagem(string usuario, FileMessage message)
        {
            Console.WriteLine($"[Facebook] Enviando arquivo '{message.File}' ({message.Format}) para {usuario}");
        }
    }
}

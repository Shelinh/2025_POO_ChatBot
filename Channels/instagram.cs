using System;
using ChatBotApp.Messages;

namespace ChatBotApp.Channels
{
    public class Instagram
    {
        public void EnviarMensagem(string usuario, TextMessage message)
        {
            Console.WriteLine($"[Instagram] Enviando texto para @{usuario}: {message.Message}");
        }

        public void EnviarMensagem(string usuario, PhotoMessage message)
        {
            Console.WriteLine($"[Instagram] Enviando foto '{message.File}' ({message.Format}) para @{usuario}");
        }

        public void EnviarMensagem(string usuario, VideoMessage message)
        {
            Console.WriteLine($"[Instagram] Enviando vídeo '{message.File}' ({message.Format}) duração {message.Duration}s para @{usuario}");
        }

        public void EnviarMensagem(string usuario, FileMessage message)
        {
            Console.WriteLine($"[Instagram] Enviando arquivo '{message.File}' ({message.Format}) para @{usuario}");
        }
    }
}

using System;
using ChatBotApp.Messages;

namespace ChatBotApp.Channels
{
    public class Telegram
    {
        public void EnviarMensagem(string destino, TextMessage message)
        {
            Console.WriteLine($"[Telegram] Enviando texto para {destino}: {message.Message}");
        }

        public void EnviarMensagem(string destino, PhotoMessage message)
        {
            Console.WriteLine($"[Telegram] Enviando foto '{message.File}' ({message.Format}) para {destino}");
        }

        public void EnviarMensagem(string destino, VideoMessage message)
        {
            Console.WriteLine($"[Telegram] Enviando vídeo '{message.File}' ({message.Format}) duração {message.Duration}s para {destino}");
        }

        public void EnviarMensagem(string destino, FileMessage message)
        {
            Console.WriteLine($"[Telegram] Enviando arquivo '{message.File}' ({message.Format}) para {destino}");
        }
    }
}

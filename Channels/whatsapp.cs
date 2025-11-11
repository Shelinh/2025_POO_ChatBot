using System;
using ChatBotApp.Channels;

namespace ChatBotApp.Channels
{
    public class WhatsApp
    {
        public void EnviarMensagem(string numero, TextMessage message)
        {
            Console.WriteLine($"[WhatsApp] Enviando texto para {numero}: {message.Message}");
        }

        public void EnviarMensagem(string numero, PhotoMessage message)
        {
            Console.WriteLine($"[WhatsApp] Enviando foto '{message.File}' ({message.Format}) para {numero}");
        }

        public void EnviarMensagem(string numero, VideoMessage message)
        {
            Console.WriteLine($"[WhatsApp] Enviando vídeo '{message.File}' ({message.Format}) duração {message.Duration}s para {numero}");
        }

        public void EnviarMensagem(string numero, FileMessage message)
        {
            Console.WriteLine($"[WhatsApp] Enviando arquivo '{message.File}' ({message.Format}) para {numero}");
        }
    }
}

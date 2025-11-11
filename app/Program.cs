using System;
using ChatBotApp.Messages;
using ChatBotApp.Channels;

namespace ChatBotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação das mensagens
            var texto = new TextMessage("Olá! Tudo bem?");
            var foto = new PhotoMessage("Confira esta foto!") { File = "foto.jpg", Format = "jpg" };
            var video = new VideoMessage("Assista a este vídeo!") { File = "video.mp4", Format = "mp4", Duration = 60 };
            var arquivo = new FileMessage("Segue o documento!") { File = "relatorio.pdf", Format = "pdf" };

            // Criação dos canais
            var whatsapp = new WhatsApp();
            var instagram = new Instagram();
            var facebook = new Facebook();
            var telegram = new Telegram();

            // Envio das mensagens
            whatsapp.EnviarMensagem("+5511999999999", texto);
            whatsapp.EnviarMensagem("+5511999999999", foto);
            instagram.EnviarMensagem("usuario_insta", video);
            facebook.EnviarMensagem("usuario_fb", arquivo);
            telegram.EnviarMensagem("@user_telegram", texto);
        }
    }
}

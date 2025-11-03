public class whatsapp
{
        public void EnviarMensagem(string numero, TextMessage message)
        {
            console.WriteLine($"Enviando mensagem de texto para numero {numero}");

        }

public void EnviarMensagem(string numero, VideoMessage message)
        {
            console.WriteLine($"Enviando mensagem de video para numero {numero}");

        }

public void EnviarMensagem(string numero, PhotoMessage message)
        {
            console.WriteLine($"Enviando mensagem de foto para numero {numero}");

        }


public void EnviarMensagem(string numero, FileMessage message)
        {
            console.WriteLine($"Enviando mensagem de arquivo para numero {numero}");

        }

}

namespace DesignPatternsCourse2.Cap6;

public class EnviaPorSms : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando a mesagem por sms");
        Console.WriteLine(mensagem.Formata());
    }
}
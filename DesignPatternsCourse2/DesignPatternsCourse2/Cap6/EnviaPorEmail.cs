namespace DesignPatternsCourse2.Cap6;

public class EnviaPorEmail : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando a mesagem por email");
        Console.WriteLine(mensagem.Formata());
    }
}
using DesignPatternsCourse2.Cap6;

namespace DesignPatternsCourse2;

public class Program
{
    public static void Main(string[] args)
    {
        IMensagem mensagem = new MensagemCliente("DELL");
        IEnviador enviador = new EnviaPorEmail();
        mensagem.Enviador = enviador;
        mensagem.Envia();
    }
}
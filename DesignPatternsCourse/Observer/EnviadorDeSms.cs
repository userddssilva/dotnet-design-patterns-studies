using DesignPatternsCourse.Builder;

namespace DesignPatternsCourse.Observer
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por Sms");
        }
    }
}
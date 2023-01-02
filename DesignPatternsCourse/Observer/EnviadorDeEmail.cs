using DesignPatternsCourse.Builder;

namespace DesignPatternsCourse.Observer
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por e-mail");
        }
    }
}
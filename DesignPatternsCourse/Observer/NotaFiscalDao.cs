using DesignPatternsCourse.Builder;

namespace DesignPatternsCourse.Observer
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salva no Banco");
        }
    }
}
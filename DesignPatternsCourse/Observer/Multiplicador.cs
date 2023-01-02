using DesignPatternsCourse.Builder;

namespace DesignPatternsCourse.Observer
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"{nf.ValorBruto * Fator}");
        }
    }
}
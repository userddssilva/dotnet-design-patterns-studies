using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.Decorator
{
    public class IMA : Imposto
    {
        public IMA()
        {
        }

        public IMA(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculoDoOutroImposto(orcamento);
        }
    }
}
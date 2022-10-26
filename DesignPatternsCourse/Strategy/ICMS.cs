namespace DesignPatternsCourse.Strategy
{
    public class ICMS : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
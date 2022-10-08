namespace DesignPatternsCourse.ChainOfResponsibility
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
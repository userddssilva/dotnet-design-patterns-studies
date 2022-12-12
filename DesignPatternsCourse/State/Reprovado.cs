using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.State
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados/finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado");
        }
    }
}
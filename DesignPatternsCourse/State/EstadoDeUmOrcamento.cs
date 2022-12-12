using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.State
{
    public interface EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento);

        public void Aprova(Orcamento orcamento);

        public void Reprova(Orcamento orcamento);

        public void Finaliza(Orcamento orcamento);
    }
}
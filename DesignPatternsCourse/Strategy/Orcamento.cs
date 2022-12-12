using DesignPatternsCourse.State;

namespace DesignPatternsCourse.Strategy
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }

        public List<Item> Itens;

        public Orcamento(double valor = 0)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Preco;
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
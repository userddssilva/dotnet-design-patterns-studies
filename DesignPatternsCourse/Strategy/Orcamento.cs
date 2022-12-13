using DesignPatternsCourse.State;

namespace DesignPatternsCourse.Strategy
{
    public class Orcamento
    {
        private bool descontoJaFoiAplicado { get; set; }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }

        public List<Item> Itens { get; set; }

        public Orcamento(double valor = 0)
        {
            descontoJaFoiAplicado = false;
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            if (!descontoJaFoiAplicado)
            {
                EstadoAtual.AplicaDescontoExtra(this);
                descontoJaFoiAplicado = true;
            }
            else
            {
                throw new Exception("O desconto já foi aplicado");
            }
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
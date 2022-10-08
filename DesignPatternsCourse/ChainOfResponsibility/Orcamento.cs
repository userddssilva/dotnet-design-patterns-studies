namespace DesignPatternsCourse.ChainOfResponsibility
{
    public class Orcamento
    {
        public double Valor;
        public List<Item> Itens;

        public Orcamento(double valor = 0)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Preco;
        }
    }
}
namespace DesignPatternsCourse.ChainOfResponsibility.Exercise1
{
    public class Item
    {
        public string Nome;
        public double Preco;

        public Item(string name, double preco)
        {
            Nome = name;
            Preco = preco;
        }
    }

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

    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }

    public class DescontoPorMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.10;
            }

            return Proximo.Desconta(orcamento);
        }
    }

    public class DescontoPorMaisDe500Reais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }

    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        
        private bool Existe(String nomeDoItem, Orcamento orcamento) 
        {
            foreach (Item item in orcamento.Itens) 
            {
                if(item.Nome.Equals(nomeDoItem)) 
                    return true;
            }
            return false;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }
    }

    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }

    public class CalculadorDeDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorMaisDeCincoItens();
            IDesconto d2 = new DescontoPorMaisDe500Reais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }

    public class Program
    {
        static void MainE1(String[] args)
        {
            CalculadorDeDesconto calculador = new CalculadorDeDesconto();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AddItem(new Item("CANETA", 250.0));
            orcamento.AddItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        }
    }
}
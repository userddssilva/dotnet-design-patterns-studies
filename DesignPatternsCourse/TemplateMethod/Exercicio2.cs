using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.TemplateMethod.Execicio2
{
    public class IHIT : TemplateDeImpostosCondicional
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.00;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.Count * 0.01;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return temDoisItensComOMesmoNome(orcamento);
        }

        public bool temDoisItensComOMesmoNome(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                var findAll = orcamento.Itens.FindAll(i => i.Nome == item.Nome);
                Console.WriteLine($"{findAll.Count}");
                if (findAll.Count == 2) return true;
            }

            return false;
        }

        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
        }

        public IHIT() : base()
        {
            
        }
    }

    public class Program
    {
        static void Main2(String[] args)
        {
            Orcamento orcamento1 = new Orcamento(600);
            Orcamento orcamento2 = new Orcamento(600);

            orcamento1.AdicionaItem(new Item("Computador", 1220.33));
            orcamento1.AdicionaItem(new Item("Computador", 15.50));
            

            orcamento2.AdicionaItem(new Item("Mesa", 800.00));
            orcamento2.AdicionaItem(new Item("Luminaria", 300.40));

            IHIT ihit = new IHIT();
            
            
            Console.WriteLine($"{ihit.temDoisItensComOMesmoNome(orcamento1)}");

            Console.WriteLine($"Imposto icc - i1: {ihit.Calcula(orcamento1)}");
            Console.WriteLine($"Imposto icc - i2: {ihit.Calcula(orcamento2)}");
        }
    }
}
using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.TemplateMethod.Execicio1
{
    public class ICPP : TemplateDeImpostosCondicional
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
    }

    public class IKCV : TemplateDeImpostosCondicional
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100No(orcamento);
        }

        private bool temItemMaiorQue100No(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Preco > 100) return true;
            }

            return false;
        }
    }

    public class Program
    {
        static void Main1(String[] args)
        {
            Orcamento orcamento1 = new Orcamento(600);
            Orcamento orcamento2 = new Orcamento(600);
            
            orcamento1.AddItem(new Item("Computador", 1220.33));
            orcamento1.AddItem(new Item("Carregador", 15.50));
            
            orcamento2.AddItem(new Item("Mesa", 800.00));
            orcamento2.AddItem(new Item("Luminaria", 300.40));

            ICCP iccp = new ICCP();
            IKCV ikcv = new IKCV();
            
            Console.WriteLine($"Imposto icc - i1: {iccp.Calcula(orcamento1)}");
            Console.WriteLine($"Imposto icc - i2: {iccp.Calcula(orcamento2)}");
            Console.WriteLine($"Imposto ikcv - i1: {ikcv.Calcula(orcamento1)}");
            Console.WriteLine($"Imposto ikcv - i2: {ikcv.Calcula(orcamento2)}");
        }
    }
}
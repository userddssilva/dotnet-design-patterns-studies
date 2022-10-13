using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.ChainOfResponsibility
{
    public class Program
    {
        static void Main2(String[] args) 
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AddItem(new Item("CANETA", 250.0));
            orcamento.AddItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        } 
    }
}
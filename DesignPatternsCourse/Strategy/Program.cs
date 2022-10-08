// See https://aka.ms/new-console-template for more information

namespace DesignPatternsCourse.Strategy
{
    public class Program
    {
        static void Main1(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500);

            CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

            calculadorDeImpostos.RealizaCalculo(orcamento, iss);
            calculadorDeImpostos.RealizaCalculo(orcamento, icms);
        }
    }
}
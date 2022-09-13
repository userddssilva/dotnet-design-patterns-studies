// See https://aka.ms/new-console-template for more information

namespace FirstPart;

public class Program
{
    static void Main(string[] args)
    {
        Imposto iss = new ISS();
        Imposto icms = new ICMS();

        Orcamento orcamento = new Orcamento(500);

        CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();
        
        calculadorDeImpostos.RealizaCalculo(orcamento, iss);
        calculadorDeImpostos.RealizaCalculo(orcamento, icms);
    }
}
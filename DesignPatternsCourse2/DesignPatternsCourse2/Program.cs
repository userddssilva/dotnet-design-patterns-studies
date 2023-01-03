using DesignPatternsCourse2.Cap4;
using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2;

public class Program
{
    public static void Main(string[] args)
    {
        IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
        IExpressao direita = new Soma(new Numero(2), new Numero(10));

        IExpressao conta = new Soma(esquerda, direita);

        int resultado = conta.Avalia();
        Console.WriteLine(resultado);

        ImpressoraPreFixa impressora = new ImpressoraPreFixa();
        conta.Aceita(impressora);
    }
}
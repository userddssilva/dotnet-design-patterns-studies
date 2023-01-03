using DesignPatternsCourse2.Cap4;

namespace DesignPatternsCourse2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            int resultado = conta.Avalia();
            Console.WriteLine(resultado);
        }
    }
}
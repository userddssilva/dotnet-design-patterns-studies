using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.Decorator
{
    public class TesteDeImposto
    {
        public class TesteDeImpostos 
        {
            static void Main1(String[] args) 
            {
                Imposto impostoComplexo = new IMA(new ICMS());

                Orcamento orcamento = new Orcamento(500.0);

                double valor = impostoComplexo.Calcula(orcamento);

                Console.WriteLine(valor);
            }
        }
    }
}
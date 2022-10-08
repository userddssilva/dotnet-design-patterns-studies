namespace DesignPatternsCourse.Strategy.Exercicio
{
    public class Orcamento
    {
        public double Valor { get; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }

    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }

    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5 + 50.0;
        }
    }

    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }
    }

    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.0)
            {
                return orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor is >= 1000.0 and < 3000.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return orcamento.Valor * 0.08 + 30.0;
            }
        }
    }

    public static class CalculadorDeImpostos
    {
        public static void CalculaImposto(Imposto imposto, Orcamento orcamento)
        {
            var valorImposto = imposto.Calcula(orcamento);
            Console.WriteLine($"Orcamento: {orcamento.Valor}");
            Console.WriteLine($"Tipo Imposto: {typeof(Imposto)}");
            Console.WriteLine($"Valor Imposto: {valorImposto}");
        }
    }
}

namespace ExercicioInvestimento
{
    public class Montante
    {
        public double Valor { get; }
    }

    public interface Investimento
    {
        public double Retorno(Montante montante);
    }

    public class Conservador : Investimento
    {
        public double Retorno(Montante montante)
        {
            return 0.08 * montante.Valor;
        }
    }

    public class Moderado : Investimento
    {
        public double Retorno(Montante montante)
        {
            bool escolhido = new Random().Next(101) > 50;
            if (escolhido) return 0.025 * montante.Valor;
            return 0.07 * montante.Valor;
        }
    }

    public class Arrojado : Investimento
    {
        public double Retorno(Montante montante)
        {
            var chance = new Random().Next(101);
            if (chance <= 20) return 0.05 * montante.Valor;
            if (chance <= 30) return 0.03 * montante.Valor;
            return 0.06 * montante.Valor;
        }
    }

    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(Investimento investimento, Montante montante)
        {
            var valorRetorno = investimento.Retorno(montante);
            Console.WriteLine($"Valor Retorno: {valorRetorno}");
        }
    }
}
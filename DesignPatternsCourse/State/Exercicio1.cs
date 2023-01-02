namespace DesignPatternsCourse.State.Exercicio
{
    public interface EstadoDaConta
    {
        public bool AplicaDescontoPorTransicao(double montante);
    }

    public class ContaNegativa : EstadoDaConta
    {
        public bool AplicaDescontoPorTransicao(double montante)
        {
            return montante - montante * 0.05;
        }
    }

    public class ContaPositiva : EstadoDaConta
    {
        public bool AplicaDescontoPorTransicao(double montante)
        {
            return montante - montante * 0.02;
        }
    }

    public class Conta
    {
        public EstadoDataconta EstadoAtual;
        public double Saldo;

        public Deposita(double montante)
        {
            double novoMontante = EstadoAtual.AplicaDescontoPorTransicao(montante);
            Saldo += novoMontante;
        }
    }
}
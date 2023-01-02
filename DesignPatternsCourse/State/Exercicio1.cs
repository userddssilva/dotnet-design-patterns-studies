namespace DesignPatternsCourse.State.Exercicio1
{
    public interface EstadoDeConta
    {
        public void Saca(Conta conta, double valor);
        public void Deposita(Conta conta, double valor);
    }

    public class ContaPositiva : EstadoDeConta
    {
        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.EstadoDaConta = new ContaNegativa();
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
    }

    public class ContaNegativa : EstadoDeConta
    {
        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Sua conta está vermelho. Não é possível sacar!");
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.EstadoDaConta = new ContaPositiva();
        }
    }

    public class Conta
    {
        public EstadoDeConta EstadoDaConta { get; set; }
        public double Saldo;

        public void Saca(double valor)
        {
            EstadoDaConta.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            EstadoDaConta.Deposita(this, valor);
        }
    }
}
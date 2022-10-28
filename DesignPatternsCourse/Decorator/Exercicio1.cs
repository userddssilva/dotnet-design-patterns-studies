namespace DesignPatternsCourse.Decorator
{
    public class Conta
    {
        public float Saldo { get; set; }
        public DateTime DataDeAbertura { get; set; }

        public Conta(float saldo, DateTime dataDeAbertura)
        {
            Saldo = saldo;
            DataDeAbertura = dataDeAbertura;
        }
    }

    public abstract class Filtro
    {
        protected Filtro? ProximoFiltro = null;

        public Filtro()
        {
            this.ProximoFiltro = null;
        }

        public Filtro(Filtro proximoFiltro)
        {
            this.ProximoFiltro = proximoFiltro;
        }

        public abstract List<Conta> Filtra(List<Conta> contas);

        protected List<Conta> AplicaOProximoFiltro(List<Conta> contas)
        {
            if (ProximoFiltro == null) return contas;
            return ProximoFiltro.Filtra(contas);
        }
    }

    public class FiltraContasComSaldoMenorQ100 : Filtro
    {
        public FiltraContasComSaldoMenorQ100() : base() { }
        public FiltraContasComSaldoMenorQ100(Filtro ProximoFiltro) : base(ProximoFiltro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            var contasComSaldoMenorQ100Reais = (List<Conta>)contas.Where(c => c.Saldo < 100);
            return AplicaOProximoFiltro(contasComSaldoMenorQ100Reais);
        }
    }

    public class FiltraContasComSaldoMaiorQ500000 : Filtro
    {
        public FiltraContasComSaldoMaiorQ500000() : base() { }

        public FiltraContasComSaldoMaiorQ500000(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            var contasComSaldoMaiorQ500000Reais = (List<Conta>)contas.Where(c => c.Saldo > 500000);
            return AplicaOProximoFiltro(contasComSaldoMaiorQ500000Reais);
        }
    }

    public class FiltraContasComMesDeCriacaoAtual : Filtro
    {
        public FiltraContasComMesDeCriacaoAtual() : base() { }

        public FiltraContasComMesDeCriacaoAtual(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            var currentDate = new DateTime();
            var contasFiltradas = (List<Conta>)contas.Where(c => c.DataDeAbertura.Month == currentDate.Month);
            return AplicaOProximoFiltro(contasFiltradas);
        }
    }

    public class ExecuteProgram
    {
        static void Main(String[] args)
        {
            var conta1 = new Conta(99, new DateTime());
            var conta2 = new Conta(500001, new DateTime());
            var conta3 = new Conta(30000, new DateTime());

            var listaDeContas = new List<Conta>();
            listaDeContas.Add(conta1);
            listaDeContas.Add(conta2);
            listaDeContas.Add(conta3);

            var filtraContasComSaldoMenorQ100 = new FiltraContasComSaldoMaiorQ500000();
            var filtraContasComSaldoMaiorQ500000 = new FiltraContasComSaldoMaiorQ500000();
            var cMenorQ100 = filtraContasComSaldoMenorQ100.Filtra(listaDeContas);
            var cMaiorQ500000 = filtraContasComSaldoMaiorQ500000.Filtra(listaDeContas);

            Console.WriteLine($"{cMenorQ100}");
            Console.WriteLine($"{cMaiorQ500000}");

            var filtrosAninhados = new FiltraContasComSaldoMaiorQ500000(
                new FiltraContasComSaldoMenorQ100(
                    new FiltraContasComMesDeCriacaoAtual()));
            filtrosAninhados.Filtra(listaDeContas);

        }
    }
}
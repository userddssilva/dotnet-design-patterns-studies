namespace DesignPatternsCourse.Decorator
{
    public class Conta
    {
        public float Saldo { get; set; }
        public DateTime dataDeCriacao { get; set; }
    }

    public abstract class Filtro
    {
        protected Filtro proximoFiltro;

        public Filtro()
        {
            this.proximoFiltro = null;
        }

        public Filtro(Filtro proximoFiltro)
        {
            this.proximoFiltro = proximoFiltro;
        }

        public abstract IList<Conta>? Filtra(IList<Conta> contas);
    }

    public class FiltraContasComSaldoMenorQ100 : Filtro
    {
        public FiltraContasComSaldoMenorQ100(){}
        public FiltraContasComSaldoMenorQ100(Conta conta){}
        public override IList<Conta>? Filtra(IList<Conta> contas)
        {
            var filtersContas = contas.Where(c => c.Saldo < 100);
            if (proximoFiltro != null)
                return proximoFiltro.Filtra(filtersContas as IList<Conta>);
            return contas;
        }
    }
    
    public class FiltraContasComSaldoMaiorQ500000: Filtro
    {
        public override IList<Conta>? Filtra(IList<Conta> contas)
        {
            var filtersContas = contas.Where(c => c.Saldo > 500000);
            if (proximoFiltro != null)
                return proximoFiltro.Filtra(filtersContas as IList<Conta>);
            return contas;
        }
    } 
}
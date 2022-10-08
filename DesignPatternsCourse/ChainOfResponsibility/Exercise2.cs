namespace DesignPatternsCourse.ChainOfResponsibility.Exercise2
{
    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    public class Requisicao
    {
        public Formato Formato { get; set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }

    public class Conta
    {
        public string NomeTitular;
        public string Saldo;

        public string GetDadosDaConta(string divisor)
        {
            return $"Titular: {NomeTitular} {divisor} Saldo: {Saldo}";
        }
    }

    public interface IFormatoDaRequisicao
    {
        public IFormatoDaRequisicao Proximo { get; set; }

        public string DefineOFormatoDaRequisicao(Requisicao requisicao);
    }

    public class RequisicaoComXml : IFormatoDaRequisicao
    {
        public IFormatoDaRequisicao Proximo { get; set; }

        public string DefineOFormatoDaRequisicao(Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.XML)
            {
                return "XML";
            }

            return Proximo.DefineOFormatoDaRequisicao(requisicao);
        }
    }

    public class RequisicaoComCsv : IFormatoDaRequisicao
    {
        public IFormatoDaRequisicao Proximo { get; set; }

        public string DefineOFormatoDaRequisicao(Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                return "CSV";
            }

            return Proximo.DefineOFormatoDaRequisicao(requisicao);
        }
    }

    public class RequisicaoComPorcento : IFormatoDaRequisicao
    {
        public IFormatoDaRequisicao Proximo { get; set; }

        public string DefineOFormatoDaRequisicao(Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                return "PORCENTO";
            }

            return Proximo.DefineOFormatoDaRequisicao(requisicao);
        }
    }

    public class RequisicaoComDefaultFormato : IFormatoDaRequisicao
    {
        public IFormatoDaRequisicao Proximo { get; set; }

        public string DefineOFormatoDaRequisicao(Requisicao requisicao)
        {
            return "XML";
        }
    }

    public class DefinidorDeFormatoDaRequisicao
    {
        public string DefinirFormato(Requisicao requisicao)
        {
            IFormatoDaRequisicao f1 = new RequisicaoComCsv();
            IFormatoDaRequisicao f2 = new RequisicaoComXml();
            IFormatoDaRequisicao f3 = new RequisicaoComPorcento();
            IFormatoDaRequisicao fd = new RequisicaoComDefaultFormato();

            f1.Proximo = f2;
            f2.Proximo = f3;
            f3.Proximo = fd;

            return f1.DefineOFormatoDaRequisicao(requisicao);
        }
    }

    public class Program
    {
        static void MainE2(String[] args)
        {
            DefinidorDeFormatoDaRequisicao definidor = new DefinidorDeFormatoDaRequisicao();

            Requisicao requisicao1 = new Requisicao(Formato.CSV);
            string formatoDaResposta = definidor.DefinirFormato(requisicao1);
            Console.WriteLine($"{formatoDaResposta}");
        }
    }
}
namespace DesignPatternsCourse.ChainOfResponsibility.Exercise3
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

        public RequisicaoComXml(IFormatoDaRequisicao proximo)
        {
            Proximo = proximo;
        }

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

        public RequisicaoComCsv(IFormatoDaRequisicao proximo)
        {
            Proximo = proximo;
        }

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

        public RequisicaoComPorcento(IFormatoDaRequisicao proximo)
        {
            Proximo = proximo;
        }

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
            IFormatoDaRequisicao fd = new RequisicaoComDefaultFormato();
            IFormatoDaRequisicao f3 = new RequisicaoComPorcento(fd);
            IFormatoDaRequisicao f2 = new RequisicaoComXml(f3);
            IFormatoDaRequisicao f1 = new RequisicaoComCsv(f2);

            return f1.DefineOFormatoDaRequisicao(requisicao);
        }
    }

    public class Program
    {
        static void MainE3(String[] args)
        {
            DefinidorDeFormatoDaRequisicao definidor = new DefinidorDeFormatoDaRequisicao();

            Requisicao requisicao1 = new Requisicao(Formato.CSV);
            string formatoDaResposta = definidor.DefinirFormato(requisicao1);
            Console.WriteLine($"{formatoDaResposta}");
        }
    }
}
namespace DesignPatternsCourse.ChainOfResponsibility.Exercise4
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

        public string DefineOFormatoDaRequisicao(Requisicao requisicao)
        {
            return "PORCENTO";

        }
    }

    public class DefinidorDeFormatoDaRequisicao
    {
        public string DefinirFormato(Requisicao requisicao)
        {
            IFormatoDaRequisicao f3 = new RequisicaoComPorcento();
            IFormatoDaRequisicao f2 = new RequisicaoComXml(f3);
            IFormatoDaRequisicao f1 = new RequisicaoComCsv(f2);

            return f1.DefineOFormatoDaRequisicao(requisicao);
        }
    }

    public class Program
    {
        static void Main(String[] args)
        {
            DefinidorDeFormatoDaRequisicao definidor = new DefinidorDeFormatoDaRequisicao();

            Requisicao requisicao1 = new Requisicao(Formato.PORCENTO);
            string formatoDaResposta = definidor.DefinirFormato(requisicao1);
            Console.WriteLine($"{formatoDaResposta}");
        }
    }
}
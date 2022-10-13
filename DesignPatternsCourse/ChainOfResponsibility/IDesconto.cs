using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.ChainOfResponsibility
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
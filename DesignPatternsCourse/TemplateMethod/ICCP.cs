using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.TemplateMethod
{
    public class ICCP : TemplateDeImpostosCondicional 
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
    }
}
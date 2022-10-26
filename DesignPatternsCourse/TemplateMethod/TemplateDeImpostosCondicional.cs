using DesignPatternsCourse.Strategy;

namespace DesignPatternsCourse.TemplateMethod
{
    public abstract class TemplateDeImpostosCondicional : Imposto
    {
        protected TemplateDeImpostosCondicional() : base()
        {
        }

        protected TemplateDeImpostosCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }

            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract double MaximaTaxacao(Orcamento orcamento);

        protected abstract double MinimaTaxacao(Orcamento orcamento);

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
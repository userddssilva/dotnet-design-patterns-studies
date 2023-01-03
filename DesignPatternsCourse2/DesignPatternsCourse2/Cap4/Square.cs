using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2.Cap4;

public class Square : IExpressao
{
    public IExpressao Expressao { get; private set; }

    public int Avalia()
    {
        int resultadoDaExpressao = Expressao.Avalia();
        return (int)Math.Sqrt(resultadoDaExpressao);
    }

    public void Aceita(IVisitor visitor)
    {
        throw new NotImplementedException();
    }
}
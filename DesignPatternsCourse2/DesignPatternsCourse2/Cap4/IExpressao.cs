using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2.Cap4;

public interface IExpressao
{
    public int Avalia();

    public void Aceita(IVisitor visitor);
}
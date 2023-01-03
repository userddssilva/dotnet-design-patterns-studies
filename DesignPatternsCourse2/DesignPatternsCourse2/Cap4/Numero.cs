using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2.Cap4;

public class Numero : IExpressao
{
    public int Valor;

    public Numero(int valor)
    {
        this.Valor = valor;
    }

    public int Avalia()
    {
        return Valor;
    }

    public void Aceita(IVisitor visitor)
    {
        visitor.ImprimeNumero(this);
    }
}
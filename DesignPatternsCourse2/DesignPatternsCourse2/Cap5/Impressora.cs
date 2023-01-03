using DesignPatternsCourse2.Cap4;

namespace DesignPatternsCourse2.Cap5;

public class Impressora : IVisitor
{
    public void ImprimeSoma(Soma soma)
    {
        Console.Write("(");
        soma.Esquerda.Aceita(this);
        Console.Write(" + ");
        soma.Direita.Aceita(this);
        Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao)
    {
        Console.Write("(");
        subtracao.Esquerda.Aceita(this);
        Console.Write(" - ");
        subtracao.Direita.Aceita(this);
        Console.Write(")");
    }

    public void ImprimeNumero(Numero numero)
    {
        Console.WriteLine(numero.Valor);
    }
}
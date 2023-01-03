using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2.Cap4;

public class Subtracao : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Subtracao(IExpressao expressao, IExpressao direita)
    {
        this.Esquerda = expressao;
        this.Direita = direita;
    }

    public int Avalia()
    {
        int resultadoDaEsquerda = Esquerda.Avalia();
        int resuladoDaDireita = Direita.Avalia();
        return resultadoDaEsquerda - resuladoDaDireita;
    }

    public void Aceita(IVisitor visitor)
    {
        visitor.ImprimeSubtracao(this);
    }
}
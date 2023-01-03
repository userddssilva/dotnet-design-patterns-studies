using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2.Cap4;

public class Soma : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Soma(IExpressao esquerda, IExpressao direita)
    {
        this.Esquerda = esquerda;
        this.Direita = direita;
    }

    public int Avalia()
    {
        int resultadoDaEsquerda = Esquerda.Avalia();
        int resuldadoDaDireita = Direita.Avalia();
        return resultadoDaEsquerda + resuldadoDaDireita;
    }

    public void Aceita(IVisitor visitor)
    {
        visitor.ImprimeSoma(this);
    }
}
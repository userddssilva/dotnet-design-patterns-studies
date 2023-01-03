using DesignPatternsCourse2.Cap5;

namespace DesignPatternsCourse2.Cap4;

public class Divisao : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Divisao(IExpressao esquerda, IExpressao direita)
    {
        this.Esquerda = esquerda;
        this.Direita = direita;
    }

    public int Avalia()
    {
        int resultadoDaEsquerda = Esquerda.Avalia();
        int resultadoDaDireita = Direita.Avalia();
        return resultadoDaEsquerda / resultadoDaDireita;
    }

    public void Aceita(IVisitor visitor)
    {
        throw new NotImplementedException();
    }
}
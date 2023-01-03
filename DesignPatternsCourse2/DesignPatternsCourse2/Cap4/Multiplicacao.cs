namespace DesignPatternsCourse2.Cap4;

public class Multiplicacao : IExpressao
{
    private IExpressao esquerda;
    private IExpressao direita;

    public Multiplicacao(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public int Avalia()
    {
        int resultadoDaEsquerda = esquerda.Avalia();
        int resultadoDaDireita = direita.Avalia();
        return resultadoDaEsquerda * resultadoDaDireita;
    }
}
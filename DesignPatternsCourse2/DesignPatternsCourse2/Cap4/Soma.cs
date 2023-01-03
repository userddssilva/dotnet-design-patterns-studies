namespace DesignPatternsCourse2.Cap4;

public class Soma : IExpressao
{
    private IExpressao esquerda;
    private IExpressao direita;

    public Soma(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public int Avalia()
    {
        int resultadoDaEsquerda = esquerda.Avalia();
        int resuldadoDaDireita = direita.Avalia();
        return resultadoDaEsquerda + resuldadoDaDireita;
    }
}
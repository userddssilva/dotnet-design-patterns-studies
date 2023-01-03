namespace DesignPatternsCourse2.Cap4;

public class Square : IExpressao
{
    private IExpressao expressao;

    public int Avalia()
    {
        int resultadoDaExpressao = expressao.Avalia();
        return (int)Math.Sqrt(resultadoDaExpressao);
    }
}
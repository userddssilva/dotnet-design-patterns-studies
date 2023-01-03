namespace DesignPatternsCourse2.Cap4;

public class Numero : IExpressao
{
    private int numero;

    public Numero(int numero)
    {
        this.numero = numero;
    }

    public int Avalia()
    {
        return numero;
    }
}
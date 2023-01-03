using DesignPatternsCourse2.Cap4;

namespace DesignPatternsCourse2.Cap5;

public interface IVisitor
{
    public void ImprimeSoma(Soma soma);
    public void ImprimeSubtracao(Subtracao subtracao);
    public void ImprimeNumero(Numero numero);
        
}
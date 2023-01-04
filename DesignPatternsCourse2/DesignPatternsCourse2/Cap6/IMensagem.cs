namespace DesignPatternsCourse2.Cap6;

public interface IMensagem
{
    public IEnviador Enviador { get; set; }
    public void Envia();

    public string Formata();
}
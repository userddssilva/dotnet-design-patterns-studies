namespace DesignPatternsCourse2.Cap6;

public class MessagemAdministrativa : IMensagem
{
    private string nome;
    public IEnviador Enviador { get; set; }

    public MessagemAdministrativa(string nome)
    {
        this.nome = nome;
    }

    public void Envia()
    {
        this.Enviador.Envia(this);
    }

    public string Formata()
    {
        return string.Format("Enviando a mensagem para o adiministrador {0}", nome);
    }
}
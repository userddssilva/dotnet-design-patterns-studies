namespace DesignPatternsCourse2.Cap3
{
    public class Contrato 
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo) 
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca() 
        {
            if(this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            else if(this.Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            else if(this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
        }
        
        public Estado SalvaEstado() 
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }

    }
}

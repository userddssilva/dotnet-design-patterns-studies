namespace DesignPatternsCourse2.Cap3
{
    public class Estado 
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato) 
        {
            this.Contrato = contrato;
        }
    }
}
namespace DesignPatternsCourse.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            
            NotaFiscal nf = builder.ComCnpj("122.123.1123312-123/11")
                .ComObservacoes("New observações")
                .ComItem(new ItemDaNota("Caderno", 100))
                .Builder();
            
            Console.WriteLine(nf.Itens);
        }
    }
}
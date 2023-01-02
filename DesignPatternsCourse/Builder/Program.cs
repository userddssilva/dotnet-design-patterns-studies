using DesignPatternsCourse.Observer;

namespace DesignPatternsCourse.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();

            builder.AdicionaAcao(new EnviadorDeEmail());
            builder.AdicionaAcao(new NotaFiscalDao());
            builder.AdicionaAcao(new EnviadorDeSms());
            builder.AdicionaAcao(new Multiplicador(10));
            
            NotaFiscal notaFiscal = builder.ComCnpj("122.123.1123312-123/11")
                .ComObservacoes("New observações")
                .ComItem(new ItemDaNota("Caderno", 100))
                .Builder();
            
            Console.WriteLine(notaFiscal.ValorBruto);
            
        }
    }
}
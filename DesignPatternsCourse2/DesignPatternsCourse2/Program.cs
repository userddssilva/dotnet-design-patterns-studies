using System.Data;
using DesignPatternsCourse2.Cap1;
using DesignPatternsCourse2.Cap2;

namespace DesignPatternsCourse2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> doReMiFa = new List<INota>() {
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("re"),
            notas.Pega("re"),

            notas.Pega("do"),
            notas.Pega("sol"),
            notas.Pega("fa"),
            notas.Pega("mi"),
            notas.Pega("mi"),
            notas.Pega("mi"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa")
        };

            Piano piano = new Piano();
            piano.Toca(doReMiFa);
        }
    }
}